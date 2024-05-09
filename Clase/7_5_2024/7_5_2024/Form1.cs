namespace _7_5_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Genero

            string genero = null;
            if (rbFemenino.Checked) genero = "Femenino";
            if (rbMasculino.Checked) genero = "Masculino";
            if (rbNoBinario.Checked) genero = "No binario";

            //Si no seleccionó ninguno
            if (genero == null)
            {
                MessageBox.Show("Debe seleccionar un genero");
            }

            Ingresante ingresante = new Ingresante(lbCursos.Items, tbDireccion.Text.Trim, (int) nEdad.Value, genero, tbNombre.Text.Trim, Convert.ToString(lbPais.Items));
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
