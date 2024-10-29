using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormHospital
{
    public partial class Pacientes : Form
    {

        bool Eliminar = false;
        public Pacientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelOpciones_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = false;
            panelBusqueda.Visible = false;
            panelAñadir.Visible = true;

            Eliminar = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = false;
            panelAñadir.Visible = false;
            panelBusqueda.Visible = true;

            Eliminar = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelModificar.Visible = false;
            panelAñadir.Visible = false;
            panelBusqueda.Visible = true;

            Eliminar = true;

        }

        private void panelBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Eliminar) { 
            
            }
            else
            {
                panelAñadir.Visible = false;
                panelBusqueda.Visible = false;
                panelModificar.Visible = true;
            }

        }
    }
}
