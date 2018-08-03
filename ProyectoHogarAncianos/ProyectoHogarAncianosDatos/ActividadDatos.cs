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

        public int CrearActvidad(Actividade actividadNueva)
        {
            try
            {
                context.Actividades.InsertOnSubmit(actividadNueva);
                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public int ModificarActvidad(Actividade actividadNueva)
        {
            try
            {
                var query = (from it in context.Actividades
                             where it.Id == actividadNueva.Id
                             select it).FirstOrDefault();
                query.Actividad = actividadNueva.Actividad;
                query.Descripcion = actividadNueva.Descripcion;
                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public List<Actividade> TraerActividad()
        {
            List<Actividade> ListaActividad = new List<Actividade>();
            try
            {
                var query = from it in context.Actividades
                            orderby it.Id ascending
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
                            where it.Actividad.ToUpper().Contains(buscarActividad.ToUpper())
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
