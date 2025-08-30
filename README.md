# Tiendita - Guía de Instalación y Ejecución

Este documento tiene como objetivo **visualizar el proceso para descargar e implementar el proyecto Tiendita**, incluyendo dependencias, migraciones y acceso al frontend.

---

## 1️⃣ Aceptar invitación

Antes de comenzar, debes **aceptar la invitación para ser colaborador del proyecto** en GitHub.  
Sin acceso, no podrás clonar ni trabajar con el repositorio.

---

## 2️⃣ Clonar el proyecto

Abre una terminal y ejecuta:

```bash
git clone git@github.com:Ioriyagami9999/tiendita.git
cd tiendita
```

Esto descargará el proyecto en tu computadora y te situará dentro de la carpeta del proyecto.

---

## 3️⃣ Instalar herramientas y paquetes necesarios

Instala la herramienta global de Entity Framework Core:

```bash
dotnet tool install --global dotnet-ef
```

Luego, agrega el paquete de diseño necesario al proyecto:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## 4️⃣ Restaurar dependencias de NuGet

Para instalar todas las librerías necesarias definidas en el proyecto:

```bash
dotnet restore
```

---

## 5️⃣ Ejecutar el proyecto

Para crear la base de datos SQLite y aplicar las migraciones automáticamente, ejecuta:

```bash
dotnet run
```

- Esto iniciará la aplicación en **modo desarrollo**.  
- La API estará disponible en `/api/productos`.  
- Swagger se podrá acceder (si está habilitado) en `/swagger`.  

---

## 6️⃣ Acceder al frontend

Una vez que la aplicación esté corriendo, abre tu navegador en:

```
http://localhost:5251/
```

- Aquí se encuentra el **index.html** que permite:  
  - Visualizar los productos en una tabla  
  - Agregar nuevos productos  
  - Eliminar productos existentes  

---

✅ **Notas adicionales**

- El puerto puede configurarse en `launchSettings.json` o usando la variable de entorno `ASPNETCORE_URLS`.  
- Asegúrate de que no haya conflictos entre la carpeta `public` y la ruta de Swagger (`/swagger`).
