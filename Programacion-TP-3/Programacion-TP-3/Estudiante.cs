using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Programacion_TP_3
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private uint edad;
        private uint anio_ingreso;

        public Estudiante(string nombre, string apellido, uint edad, uint anio_ingreso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.anio_ingreso = anio_ingreso;
        }

        // Getters
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public uint Edad { get => edad;}
        public uint Anio_ingreso { get => anio_ingreso; }

        public static float calcularPromedioEdad(Estudiante[] lista) {
            uint sumtotal = 0;
            foreach (Estudiante estudiante in lista)
            {
                sumtotal += estudiante.edad;
            }
            return (float) (sumtotal/lista.Length);
        }
    }
}