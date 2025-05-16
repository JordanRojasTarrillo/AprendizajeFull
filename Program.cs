using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(); // Importante: configura Newtonsoft.Json

// Configurar la sesión
builder.Services.AddDistributedMemoryCache(); // Requerido para la sesión
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseSession(); // Importante: debe estar después de UseRouting

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Carrito}/{action=Index}/{id?}");

app.Run();