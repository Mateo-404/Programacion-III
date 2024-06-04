using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public static class Biblioteca
    {
        public static Libro[] libros_stock = new Libro[100000];
        public static Prestamo[] prestamos = new Prestamo[100000];

        public static void agregarLibro(Libro libro)
        {
            for (uint i = 0; i < 100000; i++)
            {
                if (libros_stock[i] == null)
                {
                    libros_stock[i] = libro;
                    break;
                }
            }
        }

        public static Libro buscarLibro(long input)
        {
            for (uint i = 0; i < 100000; i++)
            {
                if (libros_stock[i] != null && libros_stock[i].ISBN1 == input)
                {
                    return libros_stock[i];
                }
            }

            return null;
        }

        //<-- Prestar libro -->
        public static Boolean prestarLibro(DateTime fecha_prestamo, DateTime fecha_devolucion, long ISBN, string lector)
        {
            // Si se encuentra el libro y hay stock
            if (buscarLibro(ISBN) != null && buscarLibro(ISBN).Ejemplares_disponibles > 0)
            {
                //Disminuye la cantidad en stock
                buscarLibro(ISBN).Ejemplares_disponibles--;
                // Se agrega el nuevo prestamo a la lista
                for (uint i = 0; i < 100000; i++)
                {
                    if (prestamos[i] == null)
                    {
                        prestamos[i] = new Prestamo(fecha_prestamo, fecha_devolucion, buscarLibro(ISBN), lector);
                        return true;
                    }
                }
            }
            // No se puede prestar el Libro: 1) El ISBN no se encuentra 2) No quedan más ejemplares en stock
            return false;
        }


        public static void devolverLibro(long ISBN, string lector){
            // Si el libro está registrado
            if (buscarLibro(ISBN) != null){
                //Aumenta stock
                buscarLibro(ISBN).Ejemplares_disponibles++;
                for (var i = 0; i < prestamos.Length; i++)
                {
                    // Se verifica la persona
                    if (lector.Equals(prestamos[i].Lector))
                    {
                        // Se anula el prestamo
                        prestamos[i] = null;
                        Console.WriteLine("Libro devuelto con exito");
                        break;
                    }
                }
            }else{
                Console.WriteLine("Libro no encontrado en el sistema");
            }
        }


        //<-- Mostrar libros --> 
        public static void mostrarLibrosDisponibles(){
            for (uint i = 0; i < libros_stock.Length; i++)
            {
                if (libros_stock[i] != null)
                {
                    Console.WriteLine($"Libro: {libros_stock[i].ISBN1} - Titulo: {libros_stock[i].Título} - Autor: {libros_stock[i].Autor} - Ejemplares disponibles: {libros_stock[i].Ejemplares_disponibles}");
                }
            }
        }

        public static void mostrarLibrosPrestados(){
            for (int i = 0; i < 100000; i++)
            {
                if (prestamos[i] != null){
                    Console.WriteLine($"Libro: {prestamos[i].Libro_prestado.ISBN1} - Titulo: {prestamos[i].Libro_prestado.Título} | Lector: {prestamos[i].Lector} - Fecha de prestamo: {prestamos[i].Fecha_prestamo} - Fecha de devolución: {prestamos[i].Fecha_devolucion}");
                }
            }
        }
    }
}