using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_2024
{
    internal class Ingresante
    {
        private string[] cursos { get; set; }
        private string direccion { get; set; }
        private string edad { get; set; }
        private long cuil { get; set; }
        private string genero { get; set; }
        private string nombre { get; set; }
        private string pais { get; set; }

        public Ingresante(string[] cursos, string direccion, string edad, long cuil, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.cuil = cuil;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public override string ToString()
        {
            //PONER TODOS
            return nombre." + cursos + "\n" + direccion + "\n" + genero + "\n" + pais + "\n" + cuil + "\n";
        }
        public string ToStringCursos()
        {
            return "Los cursos seleccionados son: \n" + curso [0] + "\n" + curso[1] + "\n" + curso [2];
        }

        //guardar
        public void Guardar()
        {
            //guardar el archivo
            try
            {

            }catch (Exception e)
            {

            }
            finally
            {

            }

        }
    }
}
