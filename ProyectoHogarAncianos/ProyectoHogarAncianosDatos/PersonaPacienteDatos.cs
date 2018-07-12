using System;
using System.Linq;
using HjaContext;

namespace ProyectoHogarAncianosDatos
{
    public class PersonaPacienteDatos
    {
        private static HjaDataContext context = new HjaDataContext();

        public static int CrearPaciente(Persona pacienteNueva, Rol nuevoRol, PersonaRol nuevoPersonaRol)
        {
            try
            {
                if (pacienteNueva != null) context.Personas.InsertOnSubmit(entity: pacienteNueva);
                if (nuevoPersonaRol != null) context.PersonaRols.InsertOnSubmit(entity:  nuevoPersonaRol);
                context.SubmitChanges();
            }
            catch (Exception e )
            {
                throw new Exception(e.Message);  
            }
            return 0;
        }

        public static Rol TraerRolPaciente()
        {
            Rol rolPaciente = null;
            String nombrePaciente = "PACIENTE";
            try
            {
                var query = from it in context.Rols
                            where it.RolNombre == nombrePaciente
                    select it;
                foreach (Rol rolLista in query)
                {
                    rolPaciente = rolLista;
                }
            }
            catch (Exception)
            {
                return rolPaciente;
            }

            return rolPaciente;
        }
    }
}
