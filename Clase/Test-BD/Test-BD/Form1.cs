using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_BD
{
    public partial class Form1 : Form
    {   /*
        public string linkBD = "Data Source=DESKTOP-60UF6SI\\SQLEXPRESS;Initial Catalog=Test1;Integrated Security=True";
        */
        string link = ConfigurationManager.AppSettings["conexion"];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(link);
                conexion.Open();
                MessageBox.Show("Conexion exitosa");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConex2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(link);
                conexion.Open();
                MessageBox.Show("Conexion exitosa");
                //<--  Mostrar Tabla de Datos -->
                // Comandos SQL
                SqlCommand command = new SqlCommand("SELECT actividad FROM actividad", conexion);
                DataTable dtListaAll = new DataTable("tipoactividad"); // Asignamos nombre a la tabla

                //  
                SqlDataAdapter sqlDat = new SqlDataAdapter(command);
                // Que hago con esta info
                sqlDat.Fill(dtListaAll);

                // Asignar datos
                cbActividad.DataSource = dtListaAll.DefaultView;
                // El valueMember no lo vemos, asigna a cada opción un valor
                cbActividad.ValueMember = "actividad";
                cbActividad.DisplayMember = "actividad";

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
