using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Prestador : Persona
    {
        public Prestador(string nombre, string apellido, string cedula, string correo, string ciudadResidencia, string fechaNacimiento, string telefono, string usuario, string clave) 
            : base(nombre, apellido, cedula, correo, ciudadResidencia, fechaNacimiento, telefono, usuario, clave)
        {
        }

        public Prestador() { }

        public Vehiculo Vehiculo { get; set; }
        public Ruta Ruta { get; set; }

    }
}
