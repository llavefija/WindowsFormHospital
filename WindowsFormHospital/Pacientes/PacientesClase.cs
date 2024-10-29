using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormHospital.PersonasClase;

namespace WindowsFormHospital
{
    internal class PacientesClase : PersonasClase
    {
        // Get y Setters
        public string Diagnostico { get; set; }
        public eGravedad GravedadPaciente { get; set; }

        // Enum para la gravedad del paciente.
        public enum eGravedad
        {
            Perfecto = 1,    // El paciente está en perfecto estado de salud.
            Leve = 2,        // El paciente tiene una condición leve, nada grave.
            Moderada = 3,    // El paciente tiene una condición moderada, requiere atención pero no es crítica.
            Grave = 4,       // El paciente está en una condición grave, necesita tratamiento urgente.
            Critica = 5      // El paciente está en estado crítico, en riesgo de muerte inminente.
        }
       
    }


}
