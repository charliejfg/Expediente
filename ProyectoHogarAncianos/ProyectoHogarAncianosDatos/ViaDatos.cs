using HjaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosDatos
{
    public class ViaDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public List<Via> TraerVias()
        {
            List<Via> ListaVia = new List<Via>(); 
            try
            {
                var query = from it in context.Vias
                            select it;

                foreach (Via ViaLista in query)
                {
                    ListaVia.Add(ViaLista);
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return ListaVia;
        }

        public Via TraerViaPorId(int idVia)
        {
            Via Via = null;
            try
            {
                var query = from it in context.Vias
                            where it.Id == idVia
                            select it;
                foreach (Via ViaLista in query)
                {
                    Via = ViaLista;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return Via;
        }
    }
}
