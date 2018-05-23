using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEUTEC;


namespace ProyectoTeoriaBD
{
    public partial class formalumnos : Form
    {
        public formalumnos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionBD();
        }

        private bool ConexionBD()
        {
            if (Auxiliar.conexion.Conectar(".", "Ceutec", "claseSQL", "123"))
            {
                MessageBox.Show("Estas conectado");
                return true;
            }
            else
            {
                MessageBox.Show("Error: "+Auxiliar.conexion.SQLError());
                return false;
            }
        }

        private void BuscarAlumno(){

            string query = "";
            DataTable dt = null;

            query = "Select * from Tablaalumno where nocuentaalumno='" + txtBuscarCeutec.Text + "'";

            if (Auxiliar.conexion.SQLSelectDataTable(query, ref dt))
            {
                gridAlumnos.DataSource = dt;
                gridAlumnos.Visible = true;
            }
            else
            {
                MessageBox.Show("Error: " + Auxiliar.conexion.SQLError());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        private void MostrarAlumnos()
        {
            string query = "";
            DataTable dt = null;

            query = "select * from Tablaalumno";

            if (Auxiliar.conexion.SQLSelectDataTable(query, ref dt))
            {
                gridAlumnos.DataSource = dt;
                gridAlumnos.Visible = true;
            }
            else
            {
                MessageBox.Show("Error: "+Auxiliar.conexion.SQLError());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarAlumno();
        }
    }
}
