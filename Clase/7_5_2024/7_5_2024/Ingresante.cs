using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_2024
{
    internal class Ingresante
    {
        private string[] cursos { get; set; }
        private string direccion { get; set; }
        private string edad { get; set; }
        private string genero { get; set; }
        private string nombre { get; set; }
        private string pais { get; set; }

        public Ingresante(string cursos, string direccion, string edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {

        }
    }
}
