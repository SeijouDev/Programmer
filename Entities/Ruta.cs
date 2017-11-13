using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ruta
    {
        public int pk { get; set; }
        public string Nombre { get; set; }
        public string PuntoInicio { get; set; }
        public string DireccionPuntoInicio { get; set; }
        public string PuntoFinal { get; set; }
        public string DireccionPuntoFinal { get; set; }
        public List<string> Trayecto { get; set; }
        public List<int> DiasDisponible { get; set; }
        public int FkPrestador { get; set; }
        public int FkVehiculo { get; set; }

        public Ruta(string nombre, string direccionInicio, double latInicio, double lngInicio, string direccionDestino,  double latFin, double lngFin, int fkPrestador)
        {
            this.Nombre = nombre;
            this.PuntoInicio =  $"{latInicio}:{lngInicio}";
            this.DireccionPuntoInicio = direccionInicio;
            this.PuntoFinal = $"{latFin}:{lngFin}";
            this.DireccionPuntoFinal = direccionDestino;
            this.Trayecto = new List<string>();
            this.DiasDisponible = new List<int>();
            this.FkPrestador = fkPrestador;
        }

        public Ruta(string nombre, string direccionInicio, double latInicio, double lngInicio, string direccionDestino, double latFin, double lngFin, int fkPrestador, int fkVehiculo)
        {
            this.Nombre = nombre;
            this.PuntoInicio = $"{latInicio}:{lngInicio}";
            this.DireccionPuntoInicio = direccionInicio;
            this.PuntoFinal = $"{latFin}:{lngFin}";
            this.DireccionPuntoFinal = direccionDestino;
            this.Trayecto = new List<string>();
            this.DiasDisponible = new List<int>();
            this.FkPrestador = fkPrestador;
            this.FkVehiculo = fkVehiculo;
        }


    }
}
