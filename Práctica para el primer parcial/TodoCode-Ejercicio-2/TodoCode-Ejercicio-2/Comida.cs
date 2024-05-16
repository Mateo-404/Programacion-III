using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCode_Ejercicio_2
{
    internal class Comida
    {
        private int id;
        private string nombre_comida;
        private double precio;

        public int Id { get => id; set => id = value; }
        public string Nombre_comida { get => nombre_comida; set => nombre_comida = value; }
        public double Precio { get => precio; set => precio = value; }

        public Comida(int id, string nombre_comida, double precio)
        {
            this.Id = id;
            this.Nombre_comida = nombre_comida;
            this.Precio = precio;
        }
    }
}
