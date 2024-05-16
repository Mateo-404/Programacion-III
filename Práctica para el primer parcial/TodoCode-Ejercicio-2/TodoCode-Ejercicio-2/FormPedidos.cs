using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoCode_Ejercicio_2
{
    public partial class FormPedidos : Form
    {
        private int count;
        private List<Comida> ListaComidas = new List<Comida>();
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPedidoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPedidoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPedidoAgregar_Click(object sender, EventArgs e)
        {
            //Se comprueba que el campo no esté vacio
            if(tbPedidoComida.Text == ""){MessageBox.Show("RELLENE EL NOMBRE DE COMIDA ANTES DE CONTINUAR");}
            
            bool flag = false;
            //Se busca la comida
            for (int i = 0; i < BaseDatos.listacomidas.Count; i++)
            {
                if (BaseDatos.listacomidas[i].Nombre_comida == tbPedidoComida.Text)
                {
                    //Se agrega la comida temporalmente a la prop de esta clase
                    tbPedidoComida.Text = "";
                    ListaComidas.Add(BaseDatos.listacomidas[i]);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("COMIDA NO ENCONTRADA, INGRESE OTRA COMIDA");
                tbPedidoComida.Text = "";
            }

        }

        private void btnPedidoGuardarPedido_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            //Se comprueba que el campo no esté vacio
            if (tbPedidoComida.Text == "" || tbPedidoNombre.Text == "" || tbPedidoApellido.Text == "")
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS REQUERIDOS");
            }

            bool flag1 = false;
            //Se busca la comida
            for (int i = 0; i < BaseDatos.listacomidas.Count; i++)
            {
                if (BaseDatos.listacomidas[i].Nombre_comida == tbPedidoComida.Text)
                {
                    //Se agrega la comida temporalmente a la prop de esta clase
                    tbPedidoComida.Text = "";
                    ListaComidas.Add(BaseDatos.listacomidas[i]);
                    flag1 = true;
                    break;
                }
            }
            if (!flag1)
            {
                MessageBox.Show("COMIDA NO ENCONTRADA, INGRESE OTRA COMIDA");
                tbPedidoComida.Text = "";
            }

            bool flag2 = false;
            //Se busca al cliente
            for (int i = 0; i < BaseDatos.listaclientes.Count; i++){
                //Cliente encontrado
                if (BaseDatos.listaclientes[i].Nombre == tbPedidoNombre.Text && BaseDatos.listaclientes[i].Apellido == tbPedidoApellido.Text){
                    flag2 = true;
                    cliente = BaseDatos.listaclientes[i];
                    MessageBox.Show("CLIENTE ENCONTRADO");
                    break;
                }
            }
            if (!flag2)
            {
                MessageBox.Show("CLIENTE NO ENCONTRADO");
                tbPedidoNombre.Text = "";
                tbPedidoApellido.Text = "";
            }
            if (cliente != null && flag1 && flag2 && ListaComidas.Count > 0)
            {
                //Se agrega el pedido a la lista de pedidos
                Pedido pedido = new Pedido(count, cliente, ListaComidas);
                BaseDatos.listapedidos.Add(pedido);
                MessageBox.Show("PEDIDO GUARDADO CON EXITO");
                count++;
                tbPedidoComida = null; tbPedidoNombre = null; tbPedidoApellido = null;
                ListaComidas = null;
            }
        }
    }
}
