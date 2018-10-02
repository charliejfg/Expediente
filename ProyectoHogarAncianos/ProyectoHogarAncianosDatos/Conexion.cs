using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosDatos
{
    public class Conexion
    {
        public DataSet conexion(string query)
        {
            string parametros = "Server=localhost;Port=5432;User Id=hja;Password=123456;Database=hja;";
            string nombre = "";
            string dato1 = string.Empty;
            string dato2 = string.Empty;
            DataSet datos = new DataSet();
            NpgsqlConnection conn = new NpgsqlConnection();

            conn.ConnectionString = parametros;

            try
            {
                conn.Open();
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(query, conn);
                add.Fill(datos);
            }
            catch (Exception)
            {
                throw;
            }

            return datos;
        }

        public NpgsqlConnection ConexionProceso()
        {
            string parametros = "Server=localhost;Port=5432;User Id=hja;Password=123456;Database=hja;";
            string nombre = "";
            string dato1 = string.Empty;
            string dato2 = string.Empty;
            DataSet datos = new DataSet();
            NpgsqlConnection conn = new NpgsqlConnection();

            conn.ConnectionString = parametros;

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            return conn;
        }
    }
}
