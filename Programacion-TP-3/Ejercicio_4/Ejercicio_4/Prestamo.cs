using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Prestamo
    {
        private DateTime fecha_prestamo;
        private DateTime fecha_devolucion;
        private Libro libro_prestado;
        private string lector;

        public Prestamo(DateTime fecha_prestamo, DateTime fecha_devolucion, Libro libro_prestado, string lector)
        {
            this.fecha_prestamo = fecha_prestamo;
            this.fecha_devolucion = fecha_devolucion;
            this.libro_prestado = libro_prestado;
            this.lector = lector;
        }

        public Libro Libro_prestado { get => libro_prestado; }
        public string Lector { get => lector;}
        public DateTime Fecha_prestamo { get => fecha_prestamo;}
        public DateTime Fecha_devolucion { get => fecha_devolucion;}
    }
}