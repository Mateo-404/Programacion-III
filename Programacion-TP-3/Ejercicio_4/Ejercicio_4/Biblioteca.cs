using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public static class Biblioteca
    {
        public static Libro[] libros_stock;
        public static Prestamo[] prestamos;
        public static void agregarLibro(Libro libro)
        {
            libros_stock[libros_stock.Length] = libro;
            Console.WriteLine("Libro agregado con exito");
        }

        public static Libro buscarLibro(long input)
        {
            for (var i = 0; i < libros_stock.Length; i++)
            {
                if (libros_stock[i].ISBN1 == input)
                {
                    return libros_stock[i];
                }
            }

            return null;
        }

        public static Boolean prestarLibro(DateTime fecha_prestamo, DateTime fecha_devolucion, long ISBN, string lector)
        {
            // Si se encuentra el libro y hay stock
            if (buscarLibro(ISBN) != null && buscarLibro(ISBN).Ejemplares_disponibles > 0)
            {
                //Disminuye la cantidad en stock
                buscarLibro(ISBN).Ejemplares_disponibles--;
                // Se agrega el nuevo prestamo a la lista
                prestamos[prestamos.Length] = new Prestamo(fecha_prestamo, fecha_devolucion, buscarLibro(ISBN), lector);
                return true;
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
                        break;
                        Console.WriteLine("Libro devuelto con exito");
                    }
                }
            }else{
                Console.WriteLine("Libro no encontrado en el sistema");
            }
        }


        //<-- Mostrar libros --> 
        //! Testear primero
        public static Libro[] mostrarLibrosDisponibles(){
            return libros_stock;
        }

        private static Libro[] mostrarLibrosPrestados(){
            Libro[] libros_prestados = new Libro[prestamos.Length];
            for (int i = 0; i < prestamos.Length; i++)
            {
                libros_prestados[i] = prestamos[i].Libro_prestado;
            }

            return libros_prestados;
        }
    }
}