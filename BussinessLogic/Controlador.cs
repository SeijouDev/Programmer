using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Controlador
    {
        public static bool ValidarNombreUsuario(string usuario)
        {
            return string.IsNullOrEmpty(usuario) ? false : Validacion.UsuarioExiste(usuario);
        }

        public static bool ValidarNuevoUsuario(Persona p)
        {
            var result = false;
            var date = DateTime.Parse(p.FechaNacimiento);

            if (GetAge(date) >= 18)
                result = true;

            return result; 
        }

        public static int ObtenerPkUsuario(string cedula, int rol)
        {
            return (rol == 0) ? new ORMPrestador().ObtenerPk(cedula) : new ORMPasajero().ObtenerPk(cedula); 
        }

        public static string CrearPasajero(Pasajero p)
        {
            var db = new ORMPasajero();
            return db.Insertar(p);
        }

        public static string CrearPrestador(Prestador p)
        {
            var db = new ORMPrestador();
            return db.Insertar(p);
        }

        public static int GetAge(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;
            return age;
        }

        public static Pasajero LoginPasajero(string usuario, string clave)
        {
            return Validacion.LoginPasajero(usuario, clave);
        }

        public static Prestador LoginPrestador(string usuario, string clave)
        {
            return Validacion.LoginPrestador(usuario, clave);
        }

        public static string CrearVehiculo(Vehiculo v)
        {
            if (v.ClaseVehiculo == "Moto" && v.Vacantes != 1)
                v.Vacantes = 1;

            var db = new ORMVehiculo();
            return db.Insertar(v);
        }

        public static List<Vehiculo> ObtenerVehiculosPorPrestador(int pk)
        {
            return (pk != 0) ? new ORMVehiculo().ConsultarPorPrestador(pk) : new List<Vehiculo>(); 
        }

        public static bool ValidarNombreRuta(string nombre, int fkPrestador)
        {
            return string.IsNullOrEmpty(nombre) ? false : Validacion.RutaExiste(nombre, fkPrestador);
        }

        public static string CrearRuta(Ruta r)
        {
            return new ORMRuta().Insertar(r);
        }

        public static List<Ruta> ObtenerRutasPorUsuario(int pk, int rol)
        {
            return (pk != 0) ? new ORMRuta().ConsultarPorUsuario(pk, rol) : new List<Ruta>();
        }

        public static List<Ruta> BuscarRutas(string str)
        {
            return new ORMRuta().ConsultarPorDireccion(str);
        }

        public static List<Ruta> BuscarRutaPorNombre(string nombre, int prestador)
        {
            return new ORMRuta().ConsultarPorNombre(nombre, prestador);
        }

        public static List<Vehiculo> BuscarVehiculoPorId(int id)
        {
            return new ORMVehiculo().ConsultarPorId(id);
        }

        public static string VincularPasajeroRuta(int pkPasajero, string nombreRuta, int pkPrestador)
        {
            var r = new ORMRuta().ConsultarPorNombre(nombreRuta, pkPrestador);

            return new ORMPasajero().VincularRuta(pkPasajero , r[0].pk );
        }
    }
}
