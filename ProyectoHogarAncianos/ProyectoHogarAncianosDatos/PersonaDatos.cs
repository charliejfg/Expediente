using System;
using System.Linq;
using HjaContext;

namespace ProyectoHogarAncianosDatos
{
    public class PersonaDatos
    {
        // Values to return operation
        // 0 = operacion esperada
        // 1 = operacion no esperada
        // 2 = operacion error de sistema (Exception)
       private static HjaDataContext context = new HjaDataContext();
        
       public static int CrearPersona(Persona personaNueva)
       {
           try
           {
               context.Personas.InsertOnSubmit(personaNueva);
               context.SubmitChanges();
           }catch (Exception){
               return 2;
           }
           return 0;
       }
        public static Persona TrearPersonaPorNombre(String nombreUsuario)
        {
            int respuesta;
            Persona personaSeleccionada = null;
            try
            {
                var query = from it in context.Personas
                    where nombreUsuario != null && it.Nombre == nombreUsuario
                    select it;
                foreach (Persona personaLista in query)
                {
                    personaSeleccionada = personaLista;
                }
            }
            catch (Exception)
            {
                return personaSeleccionada;
            }

            return personaSeleccionada;
        }

        public static int ExistePersona(String nombreUsuario)
        {
            int respuesta;
            try{Persona existePersona;
                var query = from it in context.Personas
                    where nombreUsuario != null && it.Nombre == nombreUsuario
                    select it;
                if (query.ToList().Count >= 1)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }catch (Exception)
            {
                return 2;
            }
        }
    }
}
