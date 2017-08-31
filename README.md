# Gamers
Sistema de base de datos para la gestión de una tienda de videojuegos.

## IDE
Se utilizó Visual Studio 2015 para desarrollar esta aplicación de escritorio, 
además de una base de datos con MySQL.

## Desarrolladores
Daniel Mitchel

---

# Instrucciones para instalarlo

## Requisitos
* Visual Studio 2015 o superior
* MySQL

## Pasos
* Descargar el paquete desde GitHub
* Importar la base de datos a MySQL (dentro de la carpeta de "Base de Datos" el archivo gamers.sql)
* Editar el código dentro de la carpeta Proyecto/Interfaz de Usuario/Class_/Connection.cs
Dandole valores en la función Connection.
server.- nombre de tu servidor, si es local se deja en localhost.
port.- tu puerto, normalmente se usa el 3306 para MySQL.
database.- gamers
Uid.- Nombre de usuario de tu conexión de base de datos.
pwd.- Password de tu conexión de base de datos.

### Para editar
* Abrir el proyecto desde VisualStudio (dentro de la carpeta "Interfaz de Usuario 1.1" el archivo "VideogamesStore.sln")

### Para probar
* Abrir el archivo exe (llamado Gamers.exe)
