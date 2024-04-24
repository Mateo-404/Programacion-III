using System.Collections.Specialized;

namespace Ejercicio_4
{
    internal class Program
    {
        static uint menu_principal()
        {
            Console.WriteLine("\n\n\n           |    Menu Principal   |      \n\n\n1) Agregar un nuevo libro \n2) Buscar un libro por ISBN. \n3) Prestar un libro \n4) Devolver un libro\n5) Mostrar la lista de libros disponibles\n6) Mostrar la lista de libros prestados\n0) Salir");
            return Convert.ToUInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            //test
            /*
            //Libros de prueba
            Libro libro1 = new Libro("Libro 1", "Autor 1", 123456789, "Genero 1", 10);
            Libro libro2 = new Libro("Libro 2", "Autor 2", 987654321, "Genero 2", 5);
            Libro libro3 = new Libro("Libro 3", "Autor 3", 456789123, "Genero 3", 15);
            Libro libro4 = new Libro("Libro 4", "Autor 4", 789123456, "Genero 4", 20);


            Biblioteca.agregarLibro(libro1);
            Biblioteca.agregarLibro(libro2);
            Biblioteca.agregarLibro(libro3);
            Biblioteca.agregarLibro(libro4);

            Biblioteca.mostrarLibrosDisponibles();

            //Buscar libro
            Libro prueba = Biblioteca.buscarLibro(123456789);
            Console.WriteLine($"Libro encontrado: {prueba.Título}");
            
            //Prestar libro
            Console.WriteLine("\n\n<-- PRESTAR LIBRO -->");
            Biblioteca.prestarLibro(DateTime.Now, DateTime.Now.AddDays(30), 123456789, "Juan");
            Biblioteca.mostrarLibrosDisponibles(); // deberia haber 9 ejemplares disponibles
            
            Console.WriteLine("\n\n<-- Mostrar libros prestados -->");
            Biblioteca.mostrarLibrosPrestados();

            //Devolver libro
            Console.WriteLine("\n\n<-- Devolver LIBRO -->");
            Biblioteca.devolverLibro(123456789, "Juan");
            Biblioteca.mostrarLibrosDisponibles(); // deberia haber 10 ejemplares disponibles

            */

            /*menu para:  Agregar un nuevo libro.
            ● Buscar un libro por ISBN.
            ● Prestar un libro.
            ● Devolver un libro.
            ● Mostrar la lista de libros disponibles.
            ● Mostrar la lista de libros prestados.
            */
            do
            {
                switch (menu_principal())
                {
                    case 1:
                        // <-- Agregar un nuevo libro -->
                        Console.WriteLine("\n\n<-- AGREGAR LIBRO -->");
                        string titulo, autor, genero;
                        long ISBN;
                        uint ejemplares_disponibles;

                        Console.WriteLine("Ingrese el ISBN del libro: ");
                        ISBN = long.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el titulo del libro: ");
                        titulo = Console.ReadLine();
                        Console.WriteLine("Ingrese el autor del libro: ");
                        autor = Console.ReadLine();
                        Console.WriteLine("Ingrese el genero del libro: ");
                        genero = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de ejemplares disponibles: ");
                        ejemplares_disponibles = Convert.ToUInt32(Console.ReadLine());
                        Libro libro = new Libro(titulo, autor, ISBN, genero, ejemplares_disponibles);
                        Biblioteca.agregarLibro(libro);
                        libro = null;
                        break;
                    case 2:
                        // <-- Buscar un libro por ISBN. -->
                        Console.WriteLine("\n\n<-- BUSCAR LIBRO -->");
                        Console.WriteLine("Ingrese el ISBN del libro: ");
                        ISBN = long.Parse(Console.ReadLine());
                        libro = Biblioteca.buscarLibro(ISBN);
                        if (libro == null)
                        {
                            Console.WriteLine("Libro no encontrado en el sistema");
                        }else
                        {
                            Console.WriteLine($"¡Libro encontrado! \nTitulo: {libro.Título} \nAutor: {libro.Autor} \nGenero: {libro.Género} \nEjemplares disponibles: {libro.Ejemplares_disponibles}");
                        }
                        libro = null;
                        break;
                    case 3:
                        // <-- Prestar un libro -->
                        Console.WriteLine("\n\n<-- PRESTAR LIBRO -->");
                        Console.WriteLine("Ingrese el ISBN del libro: ");
                        ISBN = long.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del lector: ");
                        string lector = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de devolución: (dd/mm/yyyy 00:00) ");
                        DateTime fecha = DateTime.Parse(Console.ReadLine());
                        Biblioteca.prestarLibro(DateTime.Now, fecha, ISBN, lector);
                        break;
                    case 4:
                        // <-- Devolver un libro -->
                        Console.WriteLine("\n\n<-- DEVOLVER LIBRO -->");
                        Console.WriteLine("Ingrese el ISBN del libro: ");
                        ISBN = long.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre del lector: ");
                        lector = Console.ReadLine();
                        Biblioteca.devolverLibro(ISBN, lector);
                        break;
                    case 5:
                        // <-- Mostrar la lista de libros Disponibles. -->
                        Console.WriteLine("\n\n<-- Mostrar libros disponibles -->");
                        Biblioteca.mostrarLibrosDisponibles();
                        break;
                    case 6:
                        // <-- Mostrar la lista de libros Prestados. -->
                        Console.WriteLine("\n\n<-- Mostrar libros prestados -->");
                        Biblioteca.mostrarLibrosPrestados();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            } while (menu_principal() != 0);
            Console.WriteLine("Disfrute su dia ;)");
        }
    }
}
