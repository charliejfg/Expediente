using System;
using System.Linq;
using HjaContext;
using System.Collections.Generic;

namespace ProyectoHogarAncianosDatos
{
    public class RecetaDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public int CrearReceta(Receta nuevaReceta)
        {
            Receta nueva = new Receta();
            try
            {
                context.Recetas.InsertOnSubmit(nuevaReceta);
                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public Receta TraerRecetaPorId(int idReceta)
        {
            Receta Receta = null;
            try
            {
                var query = from it in context.Recetas
                            where it.Id == idReceta
                            select it;
                foreach (Receta RecetaLista in query)
                {
                    Receta = RecetaLista;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return Receta;
        }

        public List<Receta> TraerReceta()
        {
            List<Receta> ListaRecetas = new List<Receta>();
            try
            {
                var query = from it in context.Recetas
                            select it;
                foreach (Receta RecetaLista in query)
                {
                    ListaRecetas.Add(RecetaLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaRecetas;
        }


    }
}
