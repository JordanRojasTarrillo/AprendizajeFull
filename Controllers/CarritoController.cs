using Microsoft.AspNetCore.Mvc;
using MiniMarketCarrito.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiniMarketCarrito.Controllers
{
    public class CarritoController : Controller
    {
        // Productos fijos para el ejemplo
        private static List<Producto> Productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Leche", Precio = 4.50m, Emoji = "🥛" },
            new Producto { Id = 2, Nombre = "Pan", Precio = 1.20m, Emoji = "🍞" },
            new Producto { Id = 3, Nombre = "Manzana", Precio = 0.80m, Emoji = "🍎" },
            new Producto { Id = 4, Nombre = "Queso", Precio = 6.00m, Emoji = "🧀" },
            new Producto { Id = 5, Nombre = "Huevos", Precio = 5.00m, Emoji = "🥚" }
        };

        // Simulación de carrito en sesión (para demo, usar base de datos en producción)
        private const string SessionKey = "Carrito";

        private List<ItemCarrito> ObtenerCarrito()
        {
            var carrito = HttpContext.Session.GetObjectFromJson<List<ItemCarrito>>(SessionKey);
            if (carrito == null)
            {
                carrito = new List<ItemCarrito>();
                HttpContext.Session.SetObjectAsJson(SessionKey, carrito);
            }
            return carrito;
        }

        private void GuardarCarrito(List<ItemCarrito> carrito)
        {
            HttpContext.Session.SetObjectAsJson(SessionKey, carrito);
        }

        public IActionResult Index()
        {
            ViewBag.Productos = Productos;
            var carrito = ObtenerCarrito();
            return View(carrito);
        }

        [HttpPost]
        public IActionResult Agregar(int id)
        {
            var carrito = ObtenerCarrito();
            var producto = Productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                var item = carrito.FirstOrDefault(i => i.Producto.Id == id);
                if (item != null)
                    item.Cantidad++;
                else
                    carrito.Add(new ItemCarrito { Producto = producto, Cantidad = 1 });
            }
            GuardarCarrito(carrito);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var carrito = ObtenerCarrito();
            var item = carrito.FirstOrDefault(i => i.Producto.Id == id);
            if (item != null)
                carrito.Remove(item);
            GuardarCarrito(carrito);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Actualizar(int id, int cantidad)
        {
            var carrito = ObtenerCarrito();
            var item = carrito.FirstOrDefault(i => i.Producto.Id == id);
            if (item != null && cantidad > 0)
                item.Cantidad = cantidad;
            GuardarCarrito(carrito);
            return RedirectToAction("Index");
        }

        public IActionResult Boleta()
        {
            var carrito = ObtenerCarrito();
            var subtotal = carrito.Sum(i => i.Producto.Precio * i.Cantidad);
            var igv = subtotal * 0.18m;
            var total = subtotal + igv;
            var boleta = new Boleta
            {
                Items = carrito,
                Subtotal = subtotal,
                IGV = igv,
                Total = total
            };
            return View(boleta);
        }

        [HttpPost]
        public IActionResult Vaciar()
        {
            GuardarCarrito(new List<ItemCarrito>());
            return RedirectToAction("Index");
        }
    }
}