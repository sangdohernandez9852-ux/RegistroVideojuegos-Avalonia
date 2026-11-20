# Registro de Videojuegos 🎮

## 1. Descripción del proyecto

Registro de Videojuegos es una aplicación de escritorio desarrollada en C# con .NET 8 y Avalonia UI.

Su objetivo es permitir al usuario administrar su propia biblioteca de videojuegos mediante una interfaz gráfica sencilla y organizada.

La información se almacena en una base de datos SQLite, permitiendo conservar los registros y consultarlos posteriormente.

## 2. Objetivo

Desarrollar una aplicación que facilite el registro y la administración de videojuegos, aplicando conceptos de Programación Orientada a Objetos (POO), interfaces gráficas y conexión a bases de datos.

## 3. Tecnologías utilizadas

- C#
- .NET 8
- Avalonia UI
- ADO.NET
- SQLite
- Visual Studio Code
- Git y GitHub

## 4. Funcionalidades principales

La aplicación permite realizar las siguientes operaciones:

- Registrar nuevos videojuegos.
- Consultar los videojuegos almacenados.
- Modificar la información de los videojuegos.
- Eliminar videojuegos de la biblioteca.
- Visualizar la lista de videojuegos registrados.
- Identificar la plataforma de cada videojuego.
- Mostrar la cantidad de videojuegos almacenados.
- Limpiar los campos del formulario.

## 5. Programación Orientada a Objetos (POO)

El proyecto utiliza Programación Orientada a Objetos para organizar el código y separar las responsabilidades de la aplicación.

Se aplican conceptos como:

- **Clases y objetos:** permiten representar los elementos principales del sistema.
- **Encapsulamiento:** permite organizar y controlar el acceso a la información.
- **Constructores y métodos:** facilitan la creación y el manejo de los objetos.
- **Separación de responsabilidades:** organiza la interfaz gráfica, los datos y la lógica del programa.

## 6. Base de datos

El sistema utiliza SQLite para almacenar la información de los videojuegos.

La conexión se realiza mediante ADO.NET utilizando la biblioteca `Microsoft.Data.Sqlite`.

Entre sus componentes principales se encuentran:

- `SqliteConnection`: establece la conexión con la base de datos.
- `SqliteCommand`: ejecuta las instrucciones SQL.
- `SqliteDataReader`: permite recuperar los registros.
- Parámetros SQL: permiten enviar información de manera segura a las consultas.

La aplicación permite registrar, consultar, modificar y eliminar información mediante operaciones CRUD.

## 7. Estructura del proyecto

El proyecto está organizado en diferentes carpetas para facilitar el mantenimiento y la comprensión del código.

- **Models:** contiene las clases que representan los datos del sistema.
- **Data:** contiene los elementos relacionados con la base de datos.
- **Services:** organiza la lógica y las operaciones del sistema.
- **Views:** contiene los archivos relacionados con la interfaz gráfica de Avalonia.

## 8. Instalación y ejecución

Para ejecutar el proyecto se necesita tener instalado el SDK de .NET 8.

Pasos:

1. Descargar o clonar el repositorio desde GitHub.
2. Abrir la carpeta del proyecto en Visual Studio Code.
3. Abrir una terminal dentro de la carpeta que contiene el archivo `.csproj`.
4. Restaurar las dependencias:

```bash
dotnet restore
```

5. Ejecutar la aplicación:

```bash
dotnet run
```

## 9. Evidencias de funcionamiento

En la carpeta `evidencias/` se encuentran las capturas de pantalla que permiten comprobar el funcionamiento de la aplicación.

Estas evidencias muestran la interfaz gráfica y las principales operaciones realizadas en el sistema.

## 10. Dificultades encontradas y soluciones

Durante el desarrollo se presentaron dificultades relacionadas con la organización del proyecto, la conexión entre los archivos de la aplicación y la implementación de la interfaz gráfica.

Estas dificultades se fueron solucionando mediante la creación y organización de los archivos necesarios, realizando pruebas hasta conseguir que la interfaz gráfica y la base de datos funcionaran correctamente.

## 11. Autor

**Sangdo Hernández Osuna**

Programa: Ingeniería de Sistemas.

Proyecto académico de Programación con C# y .NET.
