namespace Ejercicio_4
{
    internal class Program
    {
        static uint menu_principal(){
            Console.WriteLine("|    Menu Principal   | \n\n\n 1) Agregar un nuevo libro \n 2) Buscar un libro por ISBN. Prestar un libro \n3) Devolver un libro\n4) Mostrar la lista de libros disponibles\n5) Mostrar la lista de libros prestados");
            return Convert.ToUInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(menu_principal);
        }
    }
}
