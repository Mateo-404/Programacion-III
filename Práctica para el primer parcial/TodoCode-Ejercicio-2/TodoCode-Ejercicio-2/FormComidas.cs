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
    public partial class FormComidas : Form
    {
        public int count;
        public FormComidas()
        {
            InitializeComponent();
        }

        private void FormComidas_Load(object sender, EventArgs e)
        {

        }

        private void btnComidasGuardar_Click(object sender, EventArgs e)
        {
            if (tbComidasNombre.Text == "" || tbComidasPrecio.Text == "")
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS REQUERIDOS");
            }

            double precio;
            if (double.TryParse(tbComidasPrecio.Text, out precio))
            {
                Comida comida = new Comida(count, tbComidasNombre.Text, precio);
                count++;
                MessageBox.Show("COMIDA GUARDADA CON ÉXITO");
            }
            else
            {

                MessageBox.Show("INGRESE PRECIO VÁLIDO");
            }
        }
    }
}
