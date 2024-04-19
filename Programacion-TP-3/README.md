# Ejercicios sobre Miembros Estáticos y No Estáticos en C#

## Universidad Tecnológica Nacional - Facultad Regional Rafaela (UTN-FRRA)
### Tecnología en Sistemas de Programación (TSP)
### Año: 2024

Este trabajo práctico se realiza de manera individual. Cada alumno deberá entregar todos los ejercicios, cada uno como un proyecto separado. Todos los proyectos deben estar dentro de un archivo zip o rar llamado `Apellido_Nombre.zip` o `Apellido_Nombre.rar`.

## Ejercicios

### Ejercicio 1: Creación de una clase con miembros estáticos y no estáticos

Se debe crear una clase llamada `Estudiante` con los siguientes atributos:
- `nombre`: Cadena de texto que almacena el nombre del estudiante.
- `apellido`: Cadena de texto que almacena el apellido del estudiante.
- `edad`: Entero que almacena la edad del estudiante.
- `añoIngreso`: Entero que almacena el año de ingreso del estudiante.

La clase debe tener un constructor no estático que inicialice todos los atributos y un método estático llamado `calcularPromedioEdad()` que calcule y devuelva el promedio de edad de todos los estudiantes creados.

### Ejercicio 2: Creación de una clase estática con métodos y propiedades estáticos

Se debe crear una clase estática llamada `Matematicas` con un método estático llamado `sumar(int numero1, int numero2)` que sume dos números enteros y devuelva el resultado, y una propiedad estática llamada `pi` que almacene el valor de pi (3.14159).

### Ejercicio 3: Utilización de miembros estáticos para constantes

Se debe crear una clase llamada `Constantes` con las siguientes constantes estáticas:
- `NOMBRE_APLICACION`: Cadena de texto que almacena el nombre de la aplicación.
- `VERSION`: Cadena de texto que almacena la versión de la aplicación.
- `RUTA_ARCHIVO_LOG`: Cadena de texto que almacena la ruta del archivo de registro.

### Ejercicio 4: Ejercicio práctico

Se debe crear una aplicación para gestionar una biblioteca con las clases `Libro`, `Prestamo` y `Biblioteca`. La clase `Biblioteca` debe tener métodos estáticos para agregar un nuevo libro a la biblioteca, buscar un libro por ISBN, prestar un libro, devolver un libro, mostrar la lista de libros disponibles y mostrar la lista de libros prestados.
