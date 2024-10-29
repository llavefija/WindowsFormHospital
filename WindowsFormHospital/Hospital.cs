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
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelGestion.Visible = true;
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Visualizar formVisualizar = new Visualizar();

            // Mostrar el nuevo formulario
            formVisualizar.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
            // this.Close()
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Pacientes formPacientes = new Pacientes();

            // Mostrar el nuevo formulario
            formPacientes.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
            // this.Close()
        }

        private void BtnAdministrativo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            PersonalAdministrativo formAdministrativo = new PersonalAdministrativo();

            // Mostrar el nuevo formulario
            formAdministrativo.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
            // this.Close()
        }

        private void BtnSanitarios_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            PersonalSanitario formSanitarios = new PersonalSanitario();

            // Mostrar el nuevo formulario
            formSanitarios.Show();

            // Ocultar o cerrar el formulario actual
            this.Hide();
            //this.Close()
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PanelGestion.Visible = false;
            PanelMenu.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
