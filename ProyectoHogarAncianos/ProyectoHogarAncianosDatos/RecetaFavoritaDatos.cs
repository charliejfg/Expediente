using HjaContext;
using Npgsql;
using ProyectoHogarAncianosEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosDatos
{
    public class RecetaFavoritaDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public int CrearRecetaFavorita(RecetaFavorita recetaFavoritaNuevo)
        {
            try
            {
                Conexion con = new Conexion();
                string query = "INSERT INTO HJA.FAVRECETA(ID,ENCARGADO_ID, PAM_ID, FECHA) VALUES("
                + recetaFavoritaNuevo.id + recetaFavoritaNuevo.encargado_id + "," + recetaFavoritaNuevo.pam_id + ",'" + recetaFavoritaNuevo.fecha + "');";
                NpgsqlCommand command = new NpgsqlCommand(query, con.ConexionProceso());
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public int ModificarMedicamento(Medicamento medicamentoNuevo)
        {
            try
            {
                var query = (from it in context.Medicamentos
                             where it.Id == medicamentoNuevo.Id
                             select it).FirstOrDefault();
                query.Descripcion = medicamentoNuevo.Descripcion;
                query.Codigo = medicamentoNuevo.Codigo;
                query.Peso = medicamentoNuevo.Peso;
                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public RecetaFavorita TraerRecetaFavoritaPorId(int idReceta)
        {
            Conexion con = new Conexion();
            string query = "SELECT ID,ENCARGADO_ID,PAM_ID,FECHA FROM HJA.FAVRECETA WHERE ID = ;";
            DataTable dt = con.conexion(query).Tables[0];
            List<RecetaFavorita> listas = (from DataRow row in dt.Rows
                                  select new RecetaFavorita()
                                  {
                                      id = Convert.ToInt32(row["id"].ToString()),
                                      encargado_id = Convert.ToInt32(row["encargado_id"].ToString()),
                                      pam_id = Convert.ToInt32(row["pam_id"].ToString()),
                                      fecha = Convert.ToDateTime(row["fecha"].ToString())
                                  }).ToList();
            RecetaFavorita recetaFavorita = listas[0];

            return recetaFavorita;
        }

        public List<RecetaFavorita> TraerCitas()
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM HJA.FAVRECETA;";
            DataTable dt = con.conexion(query).Tables[0];
            List<RecetaFavorita> listas = (from DataRow row in dt.Rows
                                           select new RecetaFavorita()
                                           {
                                               id = Convert.ToInt32(row["id"].ToString()),
                                               encargado_id = Convert.ToInt32(row["encargado_id"].ToString()),
                                               pam_id = Convert.ToInt32(row["pam_id"].ToString()),
                                               fecha = Convert.ToDateTime(row["fecha"].ToString())
                                           }).ToList();
            List<RecetaFavorita> lista = listas;

            return lista;
        }

        public List<RecetaFavorita> TraerIdRecetaFavorita()
        {
            Conexion con = new Conexion();
            string query = "SELECT hja.getidrecetafavorita();";
            DataTable dt = con.conexion(query).Tables[0];
            List<RecetaFavorita> listas = (from DataRow row in dt.Rows
                                           select new RecetaFavorita()
                                           {
                                               id = Convert.ToInt32(row["getidrecetafavorita"].ToString()),
                                           }).ToList();
            List<RecetaFavorita> lista = listas;

            return lista;
        }

        public List<RecetaFavorita> buscarCita(String buscar)
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM HJA.CITAS INNER JOIN HJA.PACIENTE ON (CITAS.idPaciente = PACIENTE.id) WHERE PACIENTE.NOMBRE LIKE '%" + buscar + "%';";
            DataTable dt = con.conexion(query).Tables[0];
            List<RecetaFavorita> listas = (from DataRow row in dt.Rows
                                           select new RecetaFavorita()
                                           {
                                               id = Convert.ToInt32(row["id"].ToString()),
                                               encargado_id = Convert.ToInt32(row["encargado_id"].ToString()),
                                               pam_id = Convert.ToInt32(row["pam_id"].ToString()),
                                               fecha = Convert.ToDateTime(row["fecha"].ToString())
                                           }).ToList();
            List<RecetaFavorita> lista = listas;

            return lista;
        }
    }
}
