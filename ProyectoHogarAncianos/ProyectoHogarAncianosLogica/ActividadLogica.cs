using HjaContext;
using ProyectoHogarAncianosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosLogica
{
    public class ActividadLogica
    {

        public int CrearActividad(String actividad, String descripcion)
        {
            ActividadDatos nuevoDatos = new ActividadDatos();
            int respuesta;
            try
            {
                // Create a new category
                Actividade nuevaActividad = new Actividade();
                nuevaActividad.Actividad = actividad;
                nuevaActividad.Descripcion = descripcion;


                respuesta = nuevoDatos.CrearActvidad(nuevaActividad);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public int ModificarActividad(int idActividad, String actividad, String descripcion)
        {
            ActividadDatos nuevoDatos = new ActividadDatos();
            int respuesta;
            try
            {
                // Create a new category
                Actividade nuevaActividad = new Actividade();
                nuevaActividad.Id = idActividad;
                nuevaActividad.Actividad = actividad;
                nuevaActividad.Descripcion = descripcion;

                respuesta = nuevoDatos.ModificarActvidad(nuevaActividad);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public List<Actividade> TraerActividad()
        {
            ActividadDatos actividadDatos = new ActividadDatos();
            List<Actividade> ListaActividad = new List<Actividade>();

            ListaActividad = actividadDatos.TraerActividad();

            return ListaActividad;
        }

        public Actividade TraerActividadPorId(int idActividad)
        {
            ActividadDatos actividadDatos = new ActividadDatos();
            Actividade Actividad = new Actividade();

            Actividad = actividadDatos.TraerActividadPorId(idActividad);

            return Actividad;
        }

        public List<Actividade> BuscarActividad(String buscarActividad)
        {
            ActividadDatos actividadDatos = new ActividadDatos();
            List<Actividade> ListaActividad = new List<Actividade>();

            ListaActividad = actividadDatos.BuscarActividad(buscarActividad);

            return ListaActividad;
        }
    }
}
