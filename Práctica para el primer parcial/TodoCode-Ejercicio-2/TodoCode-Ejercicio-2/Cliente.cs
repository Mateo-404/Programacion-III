using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCode_Ejercicio_2
{
    internal class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string telefono;

        public Cliente()
        {
        }

        public Cliente(int id, string nombre, string apellido, string telefono)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
        }

        
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
