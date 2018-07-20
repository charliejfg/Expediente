using HjaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosDatos
{
    public class ActividadDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public List<Actividade> TraerActividad()
        {
            List<Actividade> ListaActividad = new List<Actividade>();
            try
            {
                var query = from it in context.Actividades
                            select it;
                foreach (Actividade actividadLista in query)
                {
                    ListaActividad.Add(actividadLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaActividad;
        }

        public Actividade TraerActividadPorId(int idActividad)
        {
            Actividade Actividad = new Actividade();
            try
            {
                var query = from it in context.Actividades
                            where it.Id == idActividad
                            select it;
                foreach (Actividade actividad in query)
                {
                    Actividad = actividad;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return Actividad;
        }

        public List<Actividade> BuscarActividad(String buscarActividad)
        {
            List<Actividade> ListaActividad = new List<Actividade>();
            try
            {
                var query = from it in context.Actividades
                            where it.Actividad.Contains(buscarActividad)
                            select it;
                foreach (Actividade actividadLista in query)
                {
                    ListaActividad.Add(actividadLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaActividad;
        }
    }
}
