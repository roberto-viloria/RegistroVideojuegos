
# Registro de Videojuegos - ADO.NET y SQLite

## Descripción

Este proyecto es una aplicación de consola desarrollada en C# con .NET 8.0. Su objetivo es demostrar cómo utilizar ADO.NET para conectar una aplicación con una base de datos SQLite, almacenar información y consultar los registros guardados.

## Tecnologías utilizadas

- C#
- .NET 8.0
- ADO.NET
- SQLite
- Microsoft.Data.Sqlite 8.0.25

## Funcionalidades

- Crear una base de datos SQLite.
- Establecer una conexión mediante SqliteConnection.
- Crear una tabla llamada Videojuegos.
- Insertar tres videojuegos mediante SqliteCommand.
- Utilizar parámetros SQL para insertar información.
- Consultar los registros mediante SqliteDataReader.
- Administrar los recursos mediante using.

## Estructura de la base de datos

La tabla Videojuegos contiene cuatro columnas:

- Id: identificador único.
- Nombre: nombre del videojuego.
- Genero: género del videojuego.
- Anio: año de lanzamiento.

## Videojuegos registrados

1. Minecraft - Supervivencia - 2011.
2. Grand Theft Auto V - Acción - 2013.
3. God of War - Aventura - 2018.

## Instrucciones de ejecución

1. Tener instalado el SDK de .NET 8.0.
2. Descargar o clonar este repositorio.
3. Abrir la carpeta del proyecto en Visual Studio Code.
4. Abrir una terminal dentro de la carpeta.
5. Ejecutar los siguientes comandos:

```powershell
dotnet restore
dotnet run
```

El programa creará la base de datos si no existe, insertará los tres videojuegos cuando la tabla esté vacía y mostrará los registros almacenados.

## Evidencias

Las capturas de pantalla se encuentran en la carpeta `capturas`:

- 01_Conexion.png
- 02_Insercion.png
- 03_Consulta.png

## Autor

Roberto Carlos Viloria Giraldo

## Asignatura

Programación en C# con .NET - Electiva

## Actividad

Investigación sobre ADO.NET y su aplicación en C#.

Tercer corte.
