using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using TienditaApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Registrar DbContext con SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=productos.db")); // archivo SQLite

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Carpeta pública
var publicPath = Path.Combine(builder.Environment.ContentRootPath, "public");
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

// Servir index.html desde la raíz
app.UseDefaultFiles(new DefaultFilesOptions
{
    FileProvider = new PhysicalFileProvider(publicPath),
    RequestPath = ""
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(publicPath),
    RequestPath = ""
});

// Swagger en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c =>
    {
        // Opcional: cambiar ruta del JSON
        c.RouteTemplate = "api-docs/{documentName}/swagger.json";
    });
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/api-docs/v1/swagger.json", "Tiendita API V1");
        c.RoutePrefix = "swagger"; // Acceso en /swagger
    });
}
// Mapear controladores
app.MapControllers();

// Aplicar migraciones automáticamente al iniciar
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.Run();
