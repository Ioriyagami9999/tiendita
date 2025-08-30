🛒 Tiendita - Guía de Instalación y Ejecución
Esta guía te ayudará a configurar y ejecutar el proyecto Tiendita en tu entorno local.

📋 Prerrequisitos
.NET SDK (versión compatible con el proyecto)

Git

Navegador web moderno

🚀 Inicio Rápido
1. Obtener acceso al proyecto
Asegúrate de haber aceptado la invitación como colaborador en el repositorio de GitHub.

2. Clonar el repositorio
bash
git clone git@github.com:Ioriyagami9999/tiendita.git
cd tiendita
3. Configurar el entorno
bash
# Instalar herramientas globales de EF Core
dotnet tool install --global dotnet-ef

# Agregar paquete de diseño de Entity Framework
dotnet add package Microsoft.EntityFrameworkCore.Design

# Restaurar dependencias de NuGet
dotnet restore
4. Ejecutar la aplicación
bash
dotnet run
5. Acceder a la aplicación
Frontend: http://localhost:5251/

API: http://localhost:5251/api/productos

Swagger: http://localhost:5251/swagger

🔧 Configuración Detallada
Estructura del Proyecto
text
tiendita/
├── Controllers/     # Controladores de la API
├── Models/          # Modelos de datos
├── Data/            # Contexto de base de datos
├── Migrations/      # Migraciones de EF Core
├── public/          # Frontend (archivos estáticos)
└── Program.cs       # Punto de entrada
Base de Datos
El proyecto utiliza SQLite como base de datos, que se crea automáticamente al ejecutar la aplicación por primera vez.

Personalización
Puedes modificar el puerto de ejecución editando el archivo Properties/launchSettings.json o configurando la variable de entorno:

bash
export ASPNETCORE_URLS="http://localhost:5000"
🧪 Funcionalidades Disponibles
Visualización de productos en formato de tabla

Agregar nuevos productos mediante formulario

Eliminar productos existentes

Documentación API interactiva con Swagger

❓ Solución de Problemas
Error de permisos
Si encuentras problemas al clonar el repositorio, verifica que:

Has aceptado la invitación como colaborador

Tu clave SSH está configurada correctamente en GitHub

Puerto en uso
Si el puerto 5251 está ocupado, la aplicación intentará usar otro puerto disponible. Revisa la consola para ver en qué puerto se está ejecutando.

Conflictos de rutas
Si experimentas problemas con las rutas, verifica que no haya conflictos entre la carpeta public y el endpoint de Swagger.

📞 Soporte
Si encuentras problemas durante la instalación o ejecución:

Revisa los mensajes de error en la consola

Verifica que todas las dependencias estén correctamente instaladas

Asegúrate de tener la versión correcta de .NET SDK

¡Listo! Ahora deberías tener Tiendita funcionando en tu máquina local. 🎉