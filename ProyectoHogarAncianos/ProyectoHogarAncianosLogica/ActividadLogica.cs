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
