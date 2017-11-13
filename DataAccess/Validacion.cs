using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Validacion
    {
        public static bool UsuarioExiste(string usuario)
        {
            var result = false;

            if (!string.IsNullOrEmpty(usuario))
            {
                var con = new Conexion();
                con.Conectar();

                var query = $"SELECT usuario FROM pasajero WHERE usuario = '{usuario}' AND  eliminado = 0";
                var dataTable = con.Consultar(query);

                if(dataTable != null && dataTable.Rows.Count <= 0)
                {
                    query =  $"SELECT usuario FROM prestador WHERE usuario = '{usuario}' AND  eliminado = 0";
                    dataTable = con.Consultar(query);

                    if(dataTable != null && dataTable.Rows.Count <= 0)
                        result = true;                   
                }   

                con.Desconectar();
            }
            
            return result;
        }

        public static Prestador LoginPrestador(string usuario, string clave)
        {
            Prestador result = null;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
                result = new ORMPrestador().ConsultarPorUsuario(usuario, clave);
                
            return result;
        }

        public static Pasajero LoginPasajero(string usuario, string clave)
        {
            Pasajero result = null;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
                result = new ORMPasajero().ConsultarPorUsuario(usuario, clave);

            return result;
        }

        public static bool RutaExiste(string nombre,int fkPrestador)
        {
            var result = false;

            if (!string.IsNullOrEmpty(nombre))
            {
                var con = new Conexion();
                con.Conectar();

                var query = $"SELECT nombre FROM ruta WHERE nombre = '{nombre}' AND fk_prestador = {fkPrestador} AND  eliminado = 0";
                var dataTable = con.Consultar(query);

                if (dataTable != null && dataTable.Rows.Count <= 0)
                    result = true;

                con.Desconectar();
            }

            return result;
        }
    }
}
