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

        public Receta TraerRecetaPorId(long idReceta)
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

        public List<Receta> TraerReceta(long pacienteId)
        {
            List<Receta> ListaRecetas = new List<Receta>();
            try
            {
                var query = from it in context.Recetas
                            where it.PamId == pacienteId
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


        public int CrearRecetaConListaDetalle(Receta nuevaReceta, List<RecetaDetalle> listaDetalle)
        {
            List<RecetaDetalle> listaParaGuardar = new List<RecetaDetalle>();
            try
            {
                context.Recetas.InsertOnSubmit(nuevaReceta);
                foreach (RecetaDetalle detalle in listaDetalle)
                {
                    detalle.Receta = nuevaReceta;
                    context.RecetaDetalles.InsertOnSubmit(detalle);
                }
                context.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
            return 0;
        }

        public long trearRecetaId(long pacienteId)
        {
            Receta Receta = null;
            try
            {
                var valorMaximo = context.Recetas.Max(x => x.Id);
                var query = from it in context.Recetas
                    where it.Id == valorMaximo
                    select it;
                foreach (Receta RecetaLista in query)
                {
                    Receta = RecetaLista;
                }
            }
            catch (Exception)
            {
                return 1;
            }

            return Receta.Id;
        }

        public List<RecetaDetalle> traerRecetaDetallePorRecetaId(long recetaId)
        {
            List<RecetaDetalle> listaRecetaDetalle = new List<RecetaDetalle>();
            try
            {
                var query = from it in context.RecetaDetalles
                    where it.RecetaId == recetaId
                    select it;
                foreach (RecetaDetalle detalle in query)
                {
                    listaRecetaDetalle.Add(detalle);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return listaRecetaDetalle;
        }

        public List<Receta> traerRecetaFiltradaPorRecetaId(long pacienteId, DateTime fecha1, DateTime fecha2)
        {
            List<Receta> ListaRecetas = new List<Receta>();
            try
            {
                var query = from it in context.Recetas
                    where it.PamId == pacienteId &&
                          (it.Fecha >= fecha1 && it.Fecha <= fecha2)
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

        public Persona traerPacientePorRecetaId(long idReceta)
        {
            Persona paciente = new Persona();
            try
            {
                var query = from it in context.Personas
                    join rec in context.Recetas on it.Id equals rec.PamId
                    where rec.Id == idReceta
                    select it;
                foreach (Persona persona in query)
                {
                    paciente = persona;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return paciente;
        }
    }
}
