using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ORMRuta
    {
        public string Insertar(Ruta r)
        {
            var con = new Conexion();
            con.Conectar();
            

            var query = $"INSERT INTO ruta (fk_prestador,nombre, direccion_inicio, coordenadas_inicio, direccion_destino, coordenadas_destino, fk_vehiculo ,eliminado) " +
                $"VALUES ({r.FkPrestador} ,'{r.Nombre}', '{r.DireccionPuntoInicio}', '{r.PuntoInicio}', '{r.DireccionPuntoFinal}', '{r.PuntoFinal}' , {r.FkVehiculo} ,0)";

            string res = con.EjecutarQuery(query);

            Console.WriteLine(query);

            con.Desconectar();

            return res;

        }

        public List<Ruta> ConsultarPorUsuario(int fkUsuario, int rol)
        {
            var con = new Conexion();
            con.Conectar();
            string query = string.Empty;

            if (rol == 0)
                query = $"SELECT nombre, direccion_inicio, coordenadas_inicio, direccion_destino, coordenadas_destino FROM ruta WHERE eliminado = 0 AND fk_prestador = {fkUsuario} ";
            else
                query = $"SELECT nombre, direccion_inicio, coordenadas_inicio, direccion_destino, coordenadas_destino FROM pasajero_ruta JOIN ruta r on ruta_id = fk_ruta WHERE fk_pasajero = {fkUsuario}";

            var dataTable = con.Consultar(query);
            var lista = new List<Ruta>();

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    lista.Add(
                        new Ruta(
                            row["nombre"].ToString(),
                            row["direccion_inicio"].ToString(),
                            Convert.ToDouble(row["coordenadas_inicio"].ToString().Split(':')[0]),
                            Convert.ToDouble(row["coordenadas_inicio"].ToString().Split(':')[1]),
                            row["direccion_destino"].ToString(),
                            Convert.ToDouble(row["coordenadas_destino"].ToString().Split(':')[0]),
                            Convert.ToDouble(row["coordenadas_destino"].ToString().Split(':')[1]),
                            fkUsuario
                        )  
                    );
                }
            }

            con.Desconectar();

            return lista;
        }

        public string Actualizar(Ruta r)
        {
            var con = new Conexion();
            con.Conectar();

            var query = $"UPDATE ruta SET direccion_inicio = '{r.DireccionPuntoInicio}', coordenadas_inicio = '{r.PuntoInicio}' , " +
                 $"direccion_destino = '{r.DireccionPuntoFinal}', coordenadas_destino = '{r.PuntoFinal}' " +
                $" WHERE fk_prestador = '{r.FkPrestador}' AND nombre = '{r.Nombre}' AND eliminado = 0";

            string res = con.EjecutarQuery(query);

            Console.WriteLine(query);

            con.Desconectar();

            return res;
        }

        public string Eliminar(Ruta r )
        {            
            var con = new Conexion();
            con.Conectar();
            var query = $"UPDATE ruta SET eliminado = {1} WHERE fk_prestador = {r.FkPrestador} AND nombre = '{r.Nombre}' ";
           
            var res = con.EjecutarQuery(query);

            Console.WriteLine(query);

            con.Desconectar();
            
            return res;
        }

        public List<Ruta> ConsultarPorDireccion (string str)
        {
            var con = new Conexion();
            con.Conectar();

            var query = $"SELECT nombre, direccion_inicio, coordenadas_inicio, direccion_destino, coordenadas_destino, fk_prestador FROM ruta WHERE eliminado = 0 "; 

            query += (!string.IsNullOrEmpty(str)) ?  $" AND  (direccion_inicio LIKE '%{str}%' OR direccion_destino LIKE '%{str}%' ) " : "";

            
            var dataTable = con.Consultar(query);
            var lista = new List<Ruta>();

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    lista.Add(
                        new Ruta(
                            row["nombre"].ToString(),
                            row["direccion_inicio"].ToString(),
                            Convert.ToDouble(row["coordenadas_inicio"].ToString().Split(':')[0]),
                            Convert.ToDouble(row["coordenadas_inicio"].ToString().Split(':')[1]),
                            row["direccion_destino"].ToString(),
                            Convert.ToDouble(row["coordenadas_destino"].ToString().Split(':')[0]),
                            Convert.ToDouble(row["coordenadas_destino"].ToString().Split(':')[1]),
                            Convert.ToInt32(row["fk_prestador"].ToString())
                        )
                    );
                }
            }

            con.Desconectar();

            return lista;
        }

        public List<Ruta> ConsultarPorNombre(string nombre, int prestador)
        {
            var con = new Conexion();
            con.Conectar();

            var query = $"SELECT ruta_id, nombre, direccion_inicio, coordenadas_inicio, direccion_destino, coordenadas_destino, fk_vehiculo FROM ruta WHERE eliminado = 0 AND nombre = '{nombre}' AND fk_prestador={prestador}";
            
            var dataTable = con.Consultar(query);
            var lista = new List<Ruta>();

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {

                    var r = new Ruta(
                            row["nombre"].ToString(),
                            row["direccion_inicio"].ToString(),
                            Convert.ToDouble(row["coordenadas_inicio"].ToString().Split(':')[0]),
                            Convert.ToDouble(row["coordenadas_inicio"].ToString().Split(':')[1]),
                            row["direccion_destino"].ToString(),
                            Convert.ToDouble(row["coordenadas_destino"].ToString().Split(':')[0]),
                            Convert.ToDouble(row["coordenadas_destino"].ToString().Split(':')[1]),
                            prestador,
                            Convert.ToInt32(row["fk_vehiculo"].ToString())
                        );

                    r.pk = Convert.ToInt32(row["ruta_id"].ToString());

                    lista.Add(r);
                }
            }

            con.Desconectar();

            return lista;
        }
    }

}
