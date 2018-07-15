using System;
using System.Linq;
using HjaContext;
using System.Collections.Generic;

namespace ProyectoHogarAncianosDatos
{
    public class DetallesRecetaDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public int CrearRecetaDetalle(RecetaDetalle RecetaDetalle)
        {
            Receta nueva = new Receta();
            try
            {
                context.RecetaDetalles.InsertOnSubmit(RecetaDetalle);
                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public List<RecetaDetalle> TraerRecetaDetalle(int idReceta)
        {
            List<RecetaDetalle> ListaRecetasDetalles = new List<RecetaDetalle>();
            try
            {
                var query = from it in context.RecetaDetalles
                            where it.RecetaId == idReceta
                            select it;
                foreach (RecetaDetalle RecetaDetalleLista in query)
                {
                    ListaRecetasDetalles.Add(RecetaDetalleLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaRecetasDetalles;
        }
    }
}
