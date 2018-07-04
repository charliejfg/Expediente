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

        public static int ExistePersona(String nombreUsuario)
        {
            int respuesta;
            try{Persona existePersona;
                var query = from it in context.Personas
                    where nombreUsuario != null && it.Nombre == nombreUsuario
                    select it;
                if (query.ToList().Count >= 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }catch (Exception)
            {
                return 2;
            }
        }
    }
}
