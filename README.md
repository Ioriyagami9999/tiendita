 Tiendita - Guía de Instalación y Ejecución

Esta guía te ayudará a configurar y ejecutar el proyecto Tiendita en tu entorno local.

---

 Prerrequisitos

Antes de iniciar, asegúrate de tener instalados:  
- .NET SDK (versión compatible con el proyecto)  8.0
- Git  
- Navegador web moderno

---

 Inicio Rápido

 Clonar el repositorio

Abre tu terminal y ejecuta:

git clone https://github.com/Ioriyagami9999/tiendita.git
cd tiendita

 Configurar el entorno

Instalar herramientas globales de EF Core:

 dotnet tool install --global dotnet-ef

Agregar paquete de diseño de Entity Framework:
 dotnet add package Microsoft.EntityFrameworkCore.Design

Restaurar dependencias de NuGet:

 dotnet restore

 Ejecutar la aplicación

  dotnet run

- La base de datos SQLite se creará automáticamente al ejecutar la app.  
- La aplicación se ejecutará en modo desarrollo.

---

 Acceder a la aplicación

Frontend: http://localhost:5251/  
API: http://localhost:5251/api/productos  
Swagger: http://localhost:5251/swagger

---

 Configuración Detallada

Estructura del Proyecto:


###  Descripción de carpetas

- **Controllers/** → Contiene los controladores que manejan las rutas y lógica de la API.  
- **Models/** → Define las entidades y modelos de datos usados por la aplicación.  
- **Data/** → Contiene el contexto de la base de datos y configuraciones de EF Core.  
- **Migrations/** → Guarda las migraciones generadas por EF Core para crear/actualizar la DB.  
- **public/** → Archivos estáticos del frontend (HTML, CSS, JS).  
- **Program.cs** → Punto de entrada de la aplicación, donde se configura y arranca el servidor.


Base de Datos:
- SQLite se crea automáticamente al ejecutar la app por primera vez.


---

 Funcionalidades Disponibles

- Visualización de productos en formato de tabla  
- Agregar nuevos productos mediante formulario  
- Eliminar productos existentes  
- Documentación interactiva de la API con Swagger
----


¡Listo! Ahora deberías tener Tiendita funcionando en tu máquina local.
