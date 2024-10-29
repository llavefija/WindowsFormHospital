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
    // UserControl BusquedaPacientes
    public partial class BusquedaPacientes : UserControl
    {
        private bool modoEliminar;

        // Evento para solicitar cargar un nuevo UserControl
        public event Action<UserControl> OnUserControlRequested;

        // Constructor de busqueda de pacientes
        public BusquedaPacientes(bool ModoEliminar)
        {
            InitializeComponent();
            modoEliminar = ModoEliminar;
            // Suponiendo que tienes un ListBox llamado lstPacientes
            listBoxusuarios.Items.Clear(); // Limpiar el ListBox antes de añadir los elementos

            // Filtrar las personas que sean de tipo PacientesClase y añadirlas al ListBox
            foreach (var persona in PersonasClase.PersonasHospital.OfType<PacientesClase>())
            {
                // Añadir cada paciente al ListBox mostrando nombre y DNI, o la información que necesites
                listBoxusuarios.Items.Add($"Nombre: {persona.Nombre} - DNI: {persona.Dni}");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Acciones para eliminar el usuario
            if (modoEliminar)
            {

            }
            // Acciones alternativas cuando modoEliminar es false
            else
            {
                OnUserControlRequested?.Invoke(new ModificarPacientes());
            }
        }
    }
}
