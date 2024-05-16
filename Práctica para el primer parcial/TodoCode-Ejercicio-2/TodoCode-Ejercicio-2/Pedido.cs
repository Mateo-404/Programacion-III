using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoCode_Ejercicio_2
{
    internal class Pedido
    {
        private int id;
        private Cliente cliente;
        private List<Comida> listaComidas = new List<Comida>();

        public int Id { get => id; set => id = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<Comida> ListaComidas { get => listaComidas; set => listaComidas = value; }

        public Pedido(int id, Cliente cliente, List<Comida> listaComidas)
        {
            this.Id = id;
            this.Cliente = cliente;
            this.ListaComidas = listaComidas;
        }
    }
}
