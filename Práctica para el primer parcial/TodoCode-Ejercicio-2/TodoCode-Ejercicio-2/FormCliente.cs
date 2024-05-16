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
    public partial class FormCliente : Form
    {
        private int count;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            if (tbClienteNombre.Text == "" || tbClienteNombre.Text == "" || mtbClienteTelefono.Text == "")
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS PARA CONTINUAR");
            }
            else
            {
                Cliente cliente = new Cliente(count, tbClienteNombre.Text, tbClienteApellido.Text, mtbClienteTelefono.Text);
                BaseDatos.listaclientes.Add(cliente);
                count++;
                MessageBox.Show("CLIENTE GUARDADO CON ÉXITO");
                tbClienteApellido = null; tbClienteNombre = null; mtbClienteTelefono = null;
            }
        }
    }
}
