using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormHospital
{
    internal class PersonasClase
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Nacionalidad { get; set; }
        public static List<PersonasClase> PersonasHospital { get; set; } = new List<PersonasClase>();
        public eGeneros Genero { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public DateTime FechaDeBaja { get; set; }
        public eRol Rol { get; set; }

        public enum eGeneros
        {
            Hombre = 1,
            Mujer = 2,
            NoEspecificar = 3,
        }

        public enum eRol
        {
            Trabajador = 1,
            Paciente = 2
        }

        public static int CalcularEdad(DateTime FechaNacimiento)
        {
            var today = DateTime.Today;
            var age = today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > today.AddYears(-age)) age--;
            return age;
        }

        private static string CapitalizarPrimeraLetra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            return char.ToUpper(texto[0]) + texto.Substring(1);
        }

        public static void AgregarPersona<T>(T persona) where T : PersonasClase
        {
            PersonasHospital.Add(persona);
        }

        public static void RemoverPersona<T>(T persona) where T : PersonasClase
        {
            PersonasHospital.Remove(persona);
        }

        public static bool ValidarDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni) || dni.Length != 9)
                return false;

            string numeros = dni.Substring(0, 8);
            char letra = dni[8];

            if (!int.TryParse(numeros, out _))
                return false;

            char[] letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKET".ToCharArray();
            int numeroDNI = int.Parse(numeros);
            char letraEsperada = letrasValidas[numeroDNI % 23];

            return letra == letraEsperada;
        }

        public static void ListarPersonas<T>() where T : PersonasClase
        {
            foreach (var persona in PersonasHospital.OfType<T>())
            {
                Console.WriteLine(persona.ToString());
            }
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, DNI: {Dni}, Rol: {Rol}";
        }
    }
}
