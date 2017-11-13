using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pasajero: Persona
    {

        public Pasajero(string Nombre, string Apellido, string Cedula, string Correo, string CiudadResidencia, string FechaNacimiento, string Telefono, string Usuario, string Clave) 
            : base(Nombre, Apellido, Cedula, Correo, CiudadResidencia, FechaNacimiento, Telefono, Usuario, Clave)
        {

        }

        public Pasajero() { }

        public Ruta RutaAsociada { get; set; }
    }
}
