using Microsoft.AspNetCore.Mvc;
using MiniMarketCarrito.Models;
using System.Collections.Generic;

namespace MiniMarketCarrito.Controllers
{
    public class TestController : Controller
    {
        // Lista de 20 productos para pruebas
        private static List<Producto> Productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Leche", Precio = 4.50m, Emoji = "🥛" },
            new Producto { Id = 2, Nombre = "Pan", Precio = 1.20m, Emoji = "🍞" },
            new Producto { Id = 3, Nombre = "Manzana", Precio = 0.80m, Emoji = "🍎" },
            new Producto { Id = 4, Nombre = "Queso", Precio = 6.00m, Emoji = "🧀" },
            new Producto { Id = 5, Nombre = "Huevos", Precio = 5.00m, Emoji = "🥚" },
            new Producto { Id = 6, Nombre = "Arroz", Precio = 3.00m, Emoji = "🍚" },
            new Producto { Id = 7, Nombre = "Pollo", Precio = 12.00m, Emoji = "🍗" },
            new Producto { Id = 8, Nombre = "Café", Precio = 8.50m, Emoji = "☕" },
            new Producto { Id = 9, Nombre = "Azúcar", Precio = 2.50m, Emoji = "🍬" },
            new Producto { Id = 10, Nombre = "Sal", Precio = 1.00m, Emoji = "🧂" },
            new Producto { Id = 11, Nombre = "Aceite", Precio = 7.00m, Emoji = "🛢️" },
            new Producto { Id = 12, Nombre = "Tomate", Precio = 2.20m, Emoji = "🍅" },
            new Producto { Id = 13, Nombre = "Pasta", Precio = 4.00m, Emoji = "🍝" },
            new Producto { Id = 14, Nombre = "Zanahoria", Precio = 1.80m, Emoji = "🥕" },
            new Producto { Id = 15, Nombre = "Cebolla", Precio = 1.50m, Emoji = "🧅" },
            new Producto { Id = 16, Nombre = "Pescado", Precio = 15.00m, Emoji = "🐟" },
            new Producto { Id = 17, Nombre = "Mantequilla", Precio = 6.50m, Emoji = "🧈" },
            new Producto { Id = 18, Nombre = "Yogur", Precio = 3.80m, Emoji = "🥛" },
            new Producto { Id = 19, Nombre = "Plátano", Precio = 2.00m, Emoji = "🍌" },
            new Producto { Id = 20, Nombre = "Naranja", Precio = 2.30m, Emoji = "🍊" }
        };

        public IActionResult Index()
        {
            // Ejemplo de uso de sesión
            HttpContext.Session.SetString("TestKey", "TestValue");
            ViewBag.TestValue = HttpContext.Session.GetString("TestKey");

            // Pasar la lista de productos a la vista
            ViewBag.Productos = Productos;

            return View();
        }
    }
}