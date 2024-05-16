namespace TodoCode_Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = (FormCliente)Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormCliente").SingleOrDefault();

            if (formCliente == null)
            {
                FormCliente frmp = new FormCliente();
                frmp.MdiParent = this;
                frmp.Show();
            }
            else
            {
                formCliente.Select();
                formCliente.WindowState = FormWindowState.Normal;
                formCliente.Show();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = (FormPedidos) Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormPedidos").SingleOrDefault();

            if (formPedidos == null)
            {
                formPedidos = new FormPedidos();
                formPedidos.MdiParent = this;
                formPedidos.Show();
            }
            else
            {
                formPedidos.Select();
                formPedidos.WindowState = FormWindowState.Normal;
                formPedidos.Show();
            }
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            FormComidas formComidas = (FormComidas)Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FormComidas").SingleOrDefault();

            if (formComidas == null)
            {
                formComidas = new FormComidas();
                formComidas.MdiParent = this;
                formComidas.Show();
            }
            else
            {
                formComidas.Select();
                formComidas.WindowState = FormWindowState.Normal;
                formComidas.Show();
            }
        }
    }
}
