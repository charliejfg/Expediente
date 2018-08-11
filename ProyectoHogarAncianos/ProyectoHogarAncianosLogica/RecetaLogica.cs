using HjaContext;
using ProyectoHogarAncianosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosLogica
{
    public class RecetaLogica
    {
        public int CrearReceta(int cedulaEncargado, int cedulaPaciente, DateTime fecha, List<RecetaDetalle> detalles)
        {
            RecetaDatos recetaDatos = new RecetaDatos();
            DetallesRecetaDatos detalleRecetaDatos = new DetallesRecetaDatos();
            int respuesta;
            try
            {
                // Create a new category
                Receta nuevaReceta = new Receta();
                nuevaReceta.EncargadoId = cedulaEncargado;
                nuevaReceta.PamId = cedulaPaciente;
                nuevaReceta.Fecha = fecha;
                /*
                respuesta = recetaDatos.CrearReceta(nuevaReceta);

                foreach (RecetaDetalle detalle in detalles)
                {
                    detalleRecetaDatos.CrearRecetaDetalle(detalle);
                }
                 */
                respuesta = recetaDatos.CrearRecetaConListaDetalle(nuevaReceta, detalles);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }


        public List<Receta> TraerRecetasPorPaciente(long pacienteId)
        {
            RecetaDatos recetaDatos = new RecetaDatos();
            List<Receta> ListaReceta = new List<Receta>();

            ListaReceta = recetaDatos.TraerReceta(pacienteId);

            return ListaReceta;
        }

        public Receta TraerRecetasPorId(long recetaId)
        {
            RecetaDatos recetaDatos = new RecetaDatos();
            Receta receta = new Receta();

            receta = recetaDatos.TraerRecetaPorId(recetaId);

            return receta;
        }

        public long idUltimaReceta(long pacienteId)
        {
            RecetaDatos recetaDatos = new RecetaDatos();

            return recetaDatos.trearRecetaId(pacienteId);
        }

        public List<RecetaDetalle> traerRecetaDetallePorRecetaId(long recetaId)
        {
            List<RecetaDetalle> lista = new List<RecetaDetalle>();
            RecetaDatos recetaDatos = new RecetaDatos();
            try
            {
                lista = recetaDatos.traerRecetaDetallePorRecetaId(recetaId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return lista.Any() ? lista : null;

        }

        public List<Receta> TraerRecetasFiltradoPorPaciente(long pacienteId, DateTime fecha1, DateTime fecha2)
        {
            List<Receta> lista = new List<Receta>();
            RecetaDatos recetaDatos = new RecetaDatos();
            try
            {
                lista = recetaDatos.traerRecetaFiltradaPorRecetaId(pacienteId, fecha1, fecha2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return lista.Any() ? lista : null;
        }

        public Persona TraerPacientePorReceta(long idReceta)
        {
            Persona persona = new Persona();
            RecetaDatos recetaDatos = new RecetaDatos();
            try
            {
                persona = recetaDatos.traerPacientePorRecetaId(idReceta);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return persona;
        }
    }
}
