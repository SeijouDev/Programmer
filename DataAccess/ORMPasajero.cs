using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class ORMPasajero
    {
        public string Insertar(Pasajero p)
        {
            var con = new Conexion();
            con.Conectar();

            var query = $"INSERT INTO pasajero (nombre,apellido, cedula, correo, ciudad_residencia, fecha_nacimiento, telefono, usuario, clave, eliminado) " +
                $"VALUES ('{p.Nombre}','{p.Apellido}','{p.Cedula}','{p.Correo}','{p.CiudadResidencia}','{p.FechaNacimiento}','{p.Telefono}','{p.Usuario}','{p.Clave}',0)";

            string res = con.EjecutarQuery(query);

            Console.WriteLine(query);

            con.Desconectar();

            return res;

        }

        public List<Pasajero> Consultar(string cedula = "")
        {
            var con = new Conexion();
            con.Conectar();

            var query = "SELECT nombre,apellido,cedula,correo,ciudad_residencia, fecha_nacimiento, telefono, usuario, clave FROM pasajero WHERE eliminado = 0 ";

            if (!string.IsNullOrEmpty(cedula))
                query += $"AND cedula = '{cedula}'";

            var dataTable = con.Consultar(query);
            var lista = new List<Pasajero>();

            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    lista.Add(
                        new Pasajero
                        {
                            Nombre = row["nombre"].ToString(),
                            Apellido = row["apellido"].ToString(),
                            Cedula = row["cedula"].ToString(),
                            Correo = row["correo"].ToString(),
                            CiudadResidencia = row["ciudad_residencia"].ToString(),
                            FechaNacimiento = row["fecha_nacimiento"].ToString(),
                            Telefono = row["telefono"].ToString(),
                            Usuario = row["usuario"].ToString(),
                            Clave = row["clave"].ToString()
                        }
                    );
                }
            }

            con.Desconectar();

            return lista;
        }

        public Pasajero ConsultarPorUsuario(string usuario, string clave)
        {

            Pasajero result = null;

            var con = new Conexion();
            con.Conectar();

            var query = $"SELECT nombre,apellido,cedula,correo,ciudad_residencia, fecha_nacimiento, telefono, usuario, clave FROM pasajero WHERE eliminado = 0 AND usuario = '{usuario}' AND clave = '{clave}'";

            var dataTable = con.Consultar(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                result = new Pasajero
                (
                    dataTable.Rows[0]["nombre"].ToString(),
                    dataTable.Rows[0]["apellido"].ToString(),
                    dataTable.Rows[0]["cedula"].ToString(),
                    dataTable.Rows[0]["correo"].ToString(),
                    dataTable.Rows[0]["ciudad_residencia"].ToString(),
                    dataTable.Rows[0]["fecha_nacimiento"].ToString(),
                    dataTable.Rows[0]["telefono"].ToString(),
                    usuario , clave
                );
                  
            }

            con.Desconectar();

            return result;
        }

        public string Actualizar(Prestador p)
        {
            var con = new Conexion();
            con.Conectar();

            var query = $"UPDATE pasajero SET nombre = '{p.Nombre}' , apellido = '{p.Apellido}', correo = '{p.Correo}', " +
                $"ciudad_residencia = '{p.CiudadResidencia}', fecha_nacimiento = '{p.FechaNacimiento}', telefono = '{p.Telefono}', " +
                $"usuario = '{p.Usuario}', clave = '{p.Clave}' WHERE cedula = '{p.Cedula}' AND eliminado = 0";

            string res = con.EjecutarQuery(query);

            Console.WriteLine(query);

            con.Desconectar();

            return res;
        }

        public string Eliminar(Pasajero p = null, string cedula = "")
        {
            var res = string.Empty;

            if (p != null || !string.IsNullOrEmpty(cedula))
            {
                var con = new Conexion();
                con.Conectar();
                var query = $"UPDATE pasajero SET eliminado = {1} ";

                query += (p != null) ? $"WHERE cedula = '{p.Cedula}'" : $"WHERE cedula = '{cedula}'";

                res = con.EjecutarQuery(query);

                Console.WriteLine(query);

                con.Desconectar();
            }
            else
                res = "Eliminación requiere al menos un parametro.";

            return res;
        }

        public string VincularRuta(int pkPasajero, int pkRuta)
        {
            var con = new Conexion();
            con.Conectar();

            var query = $"INSERT INTO pasajero_ruta (fk_pasajero , fk_ruta) VALUES ('{pkPasajero}','{pkRuta}')";

            string res = con.EjecutarQuery(query);

            Console.WriteLine(query);

            con.Desconectar();

            return res;

        }

        public int ObtenerPk(string cedula)
        {

            int result = 0;

            var con = new Conexion();
            con.Conectar();

            var query = $"SELECT pasajero_id FROM pasajero WHERE eliminado = 0 AND cedula = '{cedula}'";

            var dataTable = con.Consultar(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
                result = Convert.ToInt32(dataTable.Rows[0]["pasajero_id"].ToString());

            con.Desconectar();

            return result;
        }

    }
}
