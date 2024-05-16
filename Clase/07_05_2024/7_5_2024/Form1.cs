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

            Ingresante ingresante = new Ingresante(lbCursos.Items, tbDireccion.Text.Trim, (int)nEdad.Value, genero, tbNombre.Text.Trim, Convert.ToString(lbPais.Items));
            //Mostrar datos

            if ((MessageBox.Show(ingresante.ToString(), "Datos ingresante", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)) == DialogResult.OK) : 
            {

                if (!MessageBox.Show(Ingresante.ToStringCursos(), "Cursos inscripto", MessageBoxButtons.OKCancel) == DialogResult.Cancel) MessageBox("Master, ya guardaste los datos");
            }
            else
            {
                MessageBox.Show("Datos descartados master");
            }

            vaciarDatos();



        }

        //Vaciar datos
        internal void vaciarDatos()
        {
            tbDireccion.Text = "";
            tbNombre.Text = "";
            nEdad.Value = 0;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbNoBinario.Checked = false;
            mtbCUIL.Text = string.Empty;
            lbPais.Text = string.Empty;

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mtbCUIL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
