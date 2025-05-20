# 🛒 Carrito de Compras - ASP.NET Core MVC

Este proyecto es una aplicación web de carrito de compras desarrollada con **ASP.NET Core MVC**. Permite a los usuarios visualizar productos, agregarlos a un carrito, modificar cantidades, eliminar productos, vaciar el carrito y generar una boleta de compra. El diseño es moderno y responsivo, utilizando Razor para las vistas y CSS personalizado.

---

## 🚀 Características principales

- **Visualización de productos** con nombre, precio y emoji.
- **Agregar productos** al carrito desde la lista de productos disponibles.
- **Modificar cantidades** de productos en el carrito.
- **Eliminar productos** individualmente del carrito.
- **Vaciar el carrito** con un solo clic.
- **Generar boleta** de compra con el resumen de la orden.
- **Interfaz moderna y responsiva** con estilos personalizados en `wwwroot/css/estilos.css`.

---

## 📁 Estructura del proyecto

Copy
Insert

/Controllers CarritoController.cs /Models Producto.cs ItemCarrito.cs /Views /Carrito Index.cshtml Boleta.cshtml /wwwroot /css estilos.css README.md


---

## 🛠️ Instalación y ejecución

### 1. **Requisitos previos**
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) o superior
- Visual Studio, VS Code o cualquier editor compatible

### 2. **Clonar el repositorio**
```bash
git clone https://github.com/tu-usuario/tu-repo-carrito.git
cd tu-repo-carrito
Copy
Insert

3. Restaurar dependencias
dotnet restore
Copy
Insert

4. Ejecutar la aplicación
dotnet run
Copy
Insert

La aplicación estará disponible en https://localhost:5001/Carrito o http://localhost:5000/Carrito.

🧩 Componentes principales
Modelos
Producto: Representa un producto disponible para la compra.
ItemCarrito: Representa un producto y su cantidad en el carrito.
Controlador
CarritoController: Gestiona las acciones del carrito (agregar, actualizar, eliminar, vaciar, generar boleta).
Vistas
Index.cshtml: Página principal del carrito y productos.
Boleta.cshtml: Resumen de la compra.
Estilos
wwwroot/css/estilos.css: Estilos personalizados y responsivos.
💡 Datos curiosos y buenas prácticas
Utiliza Razor para mezclar HTML y C# de forma eficiente.
El proyecto es multiplataforma: funciona en Windows, Linux y macOS.
Incluye protecciones de seguridad por defecto de ASP.NET Core.
El código fuente es fácilmente extensible para agregar autenticación, base de datos, o internacionalización.
📸 Capturas de pantalla
Agrega aquí capturas de pantalla de la interfaz para ilustrar el funcionamiento.

🤝 Contribuciones
¡Las contribuciones son bienvenidas! Si encuentras un bug o quieres mejorar la aplicación, abre un issue o haz un pull request.

📄 Licencia
Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.

Desarrollado con ❤️ usando ASP.NET Core MVC
