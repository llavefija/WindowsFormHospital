using System;
using System.Windows.Forms;

namespace WindowsFormHospital
{
    public partial class ModificarPacientes : UserControl
    {
        // Constructor por defecto
        public ModificarPacientes()
        {
            InitializeComponent();
        }

        // Constructor que recibe parámetros (nombre y DNI)
        public ModificarPacientes(string nombre, string DNI)
        {
            InitializeComponent();
            // Si deseas utilizar estos parámetros, puedes asignarlos a los controles del formulario
            textBoxNombre.Text = nombre;
            textBoxDNI.Text = DNI;
        }

        // Evento que se ejecuta al hacer clic en el botón para añadir paciente
        private void button6_Click(object sender, EventArgs e)
        {
            // Validar campos (ejemplo simple)
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) || string.IsNullOrWhiteSpace(textBoxDNI.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return; // Salir del método si hay errores de validación
            }

            try
            {
                // Crear nuevo paciente
                PacientesClase paciente = new PacientesClase
                {
                    Nombre = textBoxNombre.Text,
                    FechaNacimiento = dateTimePickerFechaNacimiento.Value, // Extraer el valor
                    Dni = textBoxDNI.Text,
                    Direccion = textBoxDireccion.Text,
                    Mail = textBoxMail.Text,
                    Diagnostico = richTextBoxDiagnostico.Text,

                    // Asegurarse de que los valores se obtienen correctamente y no son nulos
                    //GravedadPaciente = comboBoxGravedad.SelectedItem is PacientesClase.eGravedad gravedad ? gravedad : throw new InvalidCastException("Gravedad no válida."),
                    //Genero = comboBoxSexo.SelectedItem is PersonasClase.eGeneros genero ? genero : throw new InvalidCastException("Género no válido."),

                    FechaDeAlta = dateTimePickerFechaAlta.Value, // Extraer el valor
                    FechaDeBaja = dateTimePickerFechaBaja.Value, // Extraer el valor

                    // Asignar Rol de manera correcta (define cómo determinar el rol)
                    Rol = PersonasClase.eRol.Paciente // Ejemplo: asumiendo que tienes un enum de roles
                };

                // Agregar el paciente a la lista o base de datos
                PersonasClase.AgregarPersona(paciente); // Asegúrate de que este método esté definido
                MessageBox.Show("Paciente añadido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al añadir el paciente: {ex.Message}");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            // Puedes implementar acciones aquí si es necesario
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Puedes implementar acciones aquí si es necesario
        }
    }
}
