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
        public int CrearReceta(int cedulaEncargado,int cedulaPaciente,DateTime fecha)
        {
            RecetaDatos recetaDatos = new RecetaDatos();
            int respuesta;
            try
            {
                // Create a new category
                Receta nuevaReceta = new Receta();
                nuevaReceta.EncargadoId = cedulaEncargado;
                nuevaReceta.PamId = cedulaPaciente;
                nuevaReceta.Fecha = fecha;

                respuesta = recetaDatos.CrearReceta(nuevaReceta);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }


        public List<Receta> TraerReceta()
        {
            RecetaDatos recetaDatos = new RecetaDatos();
            List<Receta> ListaReceta = new List<Receta>();

            ListaReceta = recetaDatos.TraerReceta();

            return ListaReceta;
        }

    }
}
