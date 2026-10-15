
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Permite abrir index.html automáticamente
app.UseDefaultFiles();

// Permite cargar CSS, imágenes y otros archivos estáticos
app.UseStaticFiles();

app.Run();
