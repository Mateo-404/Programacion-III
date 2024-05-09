namespace Formulario_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtener el numero
            int num_1 = int.Parse(textBox1.Text);
            int num_2 = int.Parse(textBox2.Text);
            //mostrar el resultado
            textBox3.Text = (num_1 + num_2).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
