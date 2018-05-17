using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTeoriaBD
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();

            cmbtipo.Items.Add("Servicios Publicos");
            cmbtipo.Items.Add("Educacional");
            cmbtipo.Items.Add("Comunicacion");

        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbtipo_TextChanged(object sender, EventArgs e)
        {
            cmbempresa.Items.Clear();
            cmbempresa.Text = "";

            if (cmbtipo.Text == "Servicios Publicos")
            {
                cmbempresa.Items.Add("ENEE");
                cmbempresa.Items.Add("Aguas SPS");

            }
            else if (cmbtipo.Text == "Educacional")
            {
                cmbempresa.Items.Add("Ceutec");

            }
            else if (cmbtipo.Text == "Comunicacion")
            {
                cmbempresa.Items.Add("CLARO");

            }
        }

        private void Continuar()
        {
            if(cmbempresa.Text=="Ceutec"){
                formalumnos fa = new formalumnos();
                fa.Visible = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Continuar();
        }
    }
}
