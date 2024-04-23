using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Libro
    {
        private string título;
        private string autor;
        private long ISBN;
        private string género; 
        private uint ejemplares_disponibles;

        public Libro(string título, string autor, long iSBN, string género, uint ejemplares_disponibles)
        {
            this.título = título;
            this.autor = autor;
            this.ISBN = iSBN;
            this.género = género;
            this.Ejemplares_disponibles = ejemplares_disponibles;
        }

        public uint Ejemplares_disponibles { get => ejemplares_disponibles; set => ejemplares_disponibles = value; }
        public long ISBN1 { get => ISBN;}
    }
}