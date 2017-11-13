using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string CiudadResidencia { get; set; }
        public string FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public Persona() { }

        public Persona(string Nombre, string Apellido, string Cedula, string Correo, string CiudadResidencia, string FechaNacimiento, string Telefono, string Usuario, string Clave)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cedula = Cedula;
            this.Correo = Correo;
            this.CiudadResidencia = CiudadResidencia;
            this.FechaNacimiento = FechaNacimiento;
            this.Telefono = Telefono;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }
    }
}
