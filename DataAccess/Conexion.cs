using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace DataAccess
{
    public class Conexion
    {
        private static string _CadenaConexion = "server=localhost; user id=root; database=car_sharing_db; pwd=root;Convert Zero Datetime=True";
        private MySqlConnection _Conexion = new MySqlConnection(_CadenaConexion);
        private MySqlDataReader mySqlDataReader;
        private string Salida;

      
        public string Conectar()
        {
            try
            {
                this._Conexion.Open();
            }
            catch (Exception ex)
            {
                this.Salida = ex.Message;
            }
            return this.Salida;
        }

        public void Desconectar()
        {
            this._Conexion.Close();
            this._Conexion.Dispose();
        }


        public string EjecutarQuery(string query)
        {
            try
            {
                var SqlQuery = new MySqlCommand(query, _Conexion);
                mySqlDataReader = SqlQuery.ExecuteReader();
                this.Salida = "1";
            }
            catch (Exception e)
            {
                this.Salida = e.Message;
            }
            
            return this.Salida;
        }

        public DataTable Consultar(string query)
        {
            var result = new DataTable();
            try
            {
                var SqlQuery = new MySqlCommand(query, _Conexion);
             
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(SqlQuery))
                {
                    adapter.Fill(result);
                }
            }
            catch (Exception e)
            {
                result = null;
            }

            return result;
        } 
    }

}
