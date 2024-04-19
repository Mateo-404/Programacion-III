namespace Programacion_TP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <-- Ejercicio 1 -->
            
            //Creación de estudiantes
            Estudiante estudiante1 = new Estudiante("Mateo", "Gariboglio", 19, 2023);
            Estudiante estudiante2 = new Estudiante("Fabian", "Gonzalez", 50, 1996);

            Estudiante[] lista = new Estudiante[] { estudiante1, estudiante2 };

            //Salida
            Console.WriteLine($"Nombre: {estudiante1.Nombre}, Apellido: {estudiante1.Apellido}, Edad: {estudiante1.Edad}, Año de Ingreso: {estudiante1.Anio_ingreso} ");
            Console.WriteLine($"Nombre: {estudiante2.Nombre}, Apellido: {estudiante2.Apellido}, Edad: {estudiante2.Edad}, Año de Ingreso: {estudiante2.Anio_ingreso} ");
            Console.WriteLine("El promedio de edad de los estudiantes es de: " + Estudiante.calcularPromedioEdad(lista));

        }
    }
}
