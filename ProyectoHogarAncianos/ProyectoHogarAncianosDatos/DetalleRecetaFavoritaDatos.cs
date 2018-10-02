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
    public class DetalleRecetaFavoritaDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public int CrearDetalleRecetaFavorita(DetalleRecetaFavorita detalleRecetaFavoritaNuevo)
        {
            try
            {
                Conexion con = new Conexion();
                string query = "INSERT INTO hja.favreceta_detalle(receta_id, medicamento_id, via_id, frecuencia, fecha)VALUES("
                + detalleRecetaFavoritaNuevo.receta_id + "," + detalleRecetaFavoritaNuevo.medicamento_id+ "," 
                +detalleRecetaFavoritaNuevo.via_id +","+ detalleRecetaFavoritaNuevo.frecuencia +"," + detalleRecetaFavoritaNuevo.fecha+"); ";
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

        public Citas TraerCitaPorId(int idCita)
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM HJA.CITAS WHERE ID = ;";
            DataTable dt = con.conexion(query).Tables[0];
            List<Citas> listas = (from DataRow row in dt.Rows
                                  select new Citas()
                                  {
                                      id = Convert.ToInt32(row["id"].ToString()),
                                      idPaciente = Convert.ToInt32(row["idPaciente"].ToString()),
                                      fecha = Convert.ToDateTime(row["fecha"].ToString()),
                                      hora = row["fecha"].ToString()
                                  }).ToList();
            Citas cita = listas[0];

            return cita;
        }

        public List<Citas> TraerCitas()
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM HJA.CITAS;";
            DataTable dt = con.conexion(query).Tables[0];
            List<Citas> listas = (from DataRow row in dt.Rows
                                  select new Citas()
                                  {
                                      id = Convert.ToInt32(row["id"].ToString()),
                                      idPaciente = Convert.ToInt32(row["idPaciente"].ToString()),
                                      fecha = Convert.ToDateTime(row["fecha"].ToString()),
                                      hora = row["fecha"].ToString()
                                  }).ToList();
            List<Citas> lista = listas;

            return lista;
        }

        public List<Citas> buscarCita(String buscar)
        {
            Conexion con = new Conexion();
            string query = "SELECT * FROM HJA.CITAS INNER JOIN HJA.PACIENTE ON (CITAS.idPaciente = PACIENTE.id) WHERE PACIENTE.NOMBRE LIKE '%" + buscar + "%';";
            DataTable dt = con.conexion(query).Tables[0];
            List<Citas> listas = (from DataRow row in dt.Rows
                                  select new Citas()
                                  {
                                      id = Convert.ToInt32(row["id"].ToString()),
                                      idPaciente = Convert.ToInt32(row["idPaciente"].ToString()),
                                      fecha = Convert.ToDateTime(row["fecha"].ToString()),
                                      hora = row["fecha"].ToString()
                                  }).ToList();
            List<Citas> lista = listas;

            return lista;
        }
    }
}
