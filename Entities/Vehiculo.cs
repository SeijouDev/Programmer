using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public string CiudadPlaca { get; set; }
        public int Modelo { get; set; }
        public string TipoCombustible { get; set; }
        public string ClaseVehiculo { get; set; }
        public int Vacantes { get; set; }
        public string Foto { get; set; }
        public int fkPrestador { get; set; }
        public int Pk { get; set; }

        public Vehiculo() { }

        public Vehiculo(string marca, string linea, string placa, string color, string ciudadPlaca, int modelo,
            string tipoCombustible, string claseVehiculo, int vacantes, string foto, int fkPrestador)
        {
            this.Marca = marca;
            this.Linea = linea;
            this.Placa = placa;
            this.Color = color;
            this.CiudadPlaca = ciudadPlaca;
            this.Modelo = modelo;
            this.TipoCombustible = tipoCombustible;
            this.ClaseVehiculo = claseVehiculo;
            this.Vacantes = vacantes;
            this.Foto = foto;
            this.fkPrestador = fkPrestador;
        }

        public Vehiculo(int pk, string marca, string linea, string placa, string color, string ciudadPlaca, int modelo,
            string tipoCombustible, string claseVehiculo, int vacantes, string foto, int fkPrestador)
        {
            this.Pk = pk;
            this.Marca = marca;
            this.Linea = linea;
            this.Placa = placa;
            this.Color = color;
            this.CiudadPlaca = ciudadPlaca;
            this.Modelo = modelo;
            this.TipoCombustible = tipoCombustible;
            this.ClaseVehiculo = claseVehiculo;
            this.Vacantes = vacantes;
            this.Foto = foto;
            this.fkPrestador = fkPrestador;
        }

    }
}
