🛒 Tiendita - Guía de Instalación y Ejecución

Esta guía te ayudará a configurar y ejecutar el proyecto Tiendita en tu entorno local.

---

📋 Prerrequisitos

Antes de iniciar, asegúrate de tener instalados:  
- .NET SDK (versión compatible con el proyecto)  
- Git  
- Navegador web moderno

---

🚀 Inicio Rápido

1️⃣ Clonar el repositorio

Abre tu terminal y ejecuta:

$ git clone git@github.com:Ioriyagami9999/tiendita.git
$ cd tiendita

2️⃣ Configurar el entorno

Instalar herramientas globales de EF Core:

$ dotnet tool install --global dotnet-ef

Agregar paquete de diseño de Entity Framework:

$ dotnet add package Microsoft.EntityFrameworkCore.Design

Restaurar dependencias de NuGet:

$ dotnet restore

3️⃣ Ejecutar la aplicación

$ dotnet run

- La base de datos SQLite se creará automáticamente al ejecutar la app.  
- La aplicación se ejecutará en modo desarrollo.

---

🌐 Acceder a la aplicación

Frontend: http://localhost:5251/  
API: http://localhost:5251/api/productos  
Swagger: http://localhost:5251/swagger

---

🔧 Configuración Detallada

Estructura del Proyecto:

tiendita/
├── Controllers/     # Controladores de la API
├── Models/          # Modelos de datos
├── Data/            # Contexto de base de datos
├── Migrations/      # Migraciones de EF Core
├── public/          # Frontend (archivos estáticos)
└── Program.cs       # Punto de entrada

Base de Datos:
- SQLite se crea automáticamente al ejecutar la app por primera vez.

Personalización del puerto:

$ export ASPNETCORE_URLS="http://localhost:5000"

---

🧪 Funcionalidades Disponibles

- Visualización de productos en formato de tabla  
- Agregar nuevos productos mediante formulario  
- Eliminar productos existentes  
- Documentación interactiva de la API con Swagger

---

❓ Solución de Problemas

Puerto en uso:  
- Si el puerto 5251 está ocupado, la app usará otro puerto disponible. Revisa la consola.

Conflictos de rutas:  
- Evita conflictos entre la carpeta public y el endpoint de Swagger.

---

📞 Soporte

- Revisa los mensajes de error en la consola  
- Asegúrate de tener todas las dependencias instaladas  
- Verifica que la versión de .NET SDK sea la correcta

---

¡Listo! Ahora deberías tener Tiendita funcionando en tu máquina local.
