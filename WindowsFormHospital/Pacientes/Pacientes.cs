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
    // Formulario principal que contiene panelAñadir para cargar UserControls
    public partial class Pacientes : Form
    {
        bool modoEliminar = false;
        private ModificarPacientes userControlModificar;
        private BusquedaPacientes userControlBusqueda;

        public Pacientes()
        {
            InitializeComponent();
            userControlModificar = new ModificarPacientes();
            cargarUserController(userControlModificar);
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            userControlModificar = new ModificarPacientes();
            cargarUserController(userControlModificar);
            modoEliminar = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modoEliminar = false;
            cargarBusquedaUserControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modoEliminar = true;
            cargarBusquedaUserControl();
        }

        // Carga el UserControl BusquedaPacientes y se suscribe al evento OnUserControlRequested
        private void cargarBusquedaUserControl()
        {
            userControlBusqueda = new BusquedaPacientes(modoEliminar);
            userControlBusqueda.OnUserControlRequested += HandleUserControlRequest; // Suscribirse al evento
            cargarUserController(userControlBusqueda);
        }

        private void HandleUserControlRequest(UserControl requestedControl)
        {
            cargarUserController(requestedControl);
        }

        // Carga cualquier UserControl en panelAñadir
        private void cargarUserController(UserControl userControl)
        {
            panelAñadir.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelAñadir.Controls.Add(userControl);
        }
    }
}