using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. Agrega el servicio de caché distribuida antes de la sesión
builder.Services.AddDistributedMemoryCache();

// 2. Agrega el servicio de sesión con opciones recomendadas
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Tiempo de expiración de la sesión
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// 3. Agrega controladores con vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// 4. Usa archivos estáticos
app.UseStaticFiles();

// 5. Usa enrutamiento
app.UseRouting();

// 6. Usa sesión (¡debe ir antes de UseAuthorization y después de UseRouting!)
app.UseSession();

// 7. Usa autorización (si la tienes, si no puedes omitir)
app.UseAuthorization();

// 8. Mapea las rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Carrito}/{action=Index}/{id?}");

app.Run();