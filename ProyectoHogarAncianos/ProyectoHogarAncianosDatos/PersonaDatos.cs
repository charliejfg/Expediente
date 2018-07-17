using System;
using System.Linq;
using HjaContext;
using System.Collections.Generic;

namespace ProyectoHogarAncianosDatos
{
    public class PersonaDatos
    {
        // Values to return operation
        // 0 = operacion esperada
        // 1 = operacion no esperada
        // 2 = operacion error de sistema (Exception)
       private HjaDataContext context = new HjaDataContext();
        
       public int CrearPersona(Persona personaNueva, Rol nuevoRol , PersonaRol nuevoPersonaRol)
       {
           Receta nueva = new Receta();
           try
           {
               context.Personas.InsertOnSubmit(personaNueva);
               context.Rols.InsertOnSubmit(nuevoRol);
               context.PersonaRols.InsertOnSubmit(nuevoPersonaRol);
               context.SubmitChanges();
           }catch (Exception){
               return 2;
           }
           return 0;
       }
        public Persona TrearPersonaPorCedula(String cedula)
        {
            Persona personaSeleccionada = null;
            try
            {
                var query = from it in context.Personas
                            join dist in context.PersonaRols on it.Id equals dist.PersonaId
                            join de in context.Rols on dist.RolId equals de.Id
                            where cedula != null && it.Cedula == cedula && de.RolNombre == "ADMIN"
                            
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

        public Persona TrearPacientePorCedula(String cedula)
        {
            Persona personaSeleccionada = null;
            try
            {
                var query = from it in context.Personas
                            join dist in context.PersonaRols on it.Id equals dist.PersonaId
                            join de in context.Rols on dist.RolId equals de.Id
                            where cedula != null && it.Cedula == cedula && de.RolNombre == "PACIENTE"

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

        public List<Persona> TraerPacientes()
        {
            List<Persona> ListaPacientes = new List<Persona>();
            try
            {
                var query = from it in context.Personas
                            join dist in context.PersonaRols on it.Id equals dist.PersonaId
                            join de in context.Rols on dist.RolId equals de.Id
                            where de.RolNombre == "PACIENTE"
                            select it;
                foreach (Persona personaLista in query)
                {
                    ListaPacientes.Add(personaLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaPacientes;
        }

        public List<Persona> BuscarPacientes(String buscar)
        {
            List<Persona> ListaPacientes = new List<Persona>();
            try
            {
                var query = from it in context.Personas
                            join dist in context.PersonaRols on it.Id equals dist.PersonaId
                            join de in context.Rols on dist.RolId equals de.Id
                            where de.RolNombre == "PACIENTE" 
                            && (it.Cedula.Contains(buscar) || it.Nombre.Contains(buscar))
                            select it;
                foreach (Persona personaLista in query)
                {
                    ListaPacientes.Add(personaLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaPacientes;
        }

        public int ExistePersona(String cedula)
        {
            try{
                var query = from it in context.Personas
                            where cedula != null && it.Cedula == cedula
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

        public Rol TraerRolAdmin()
        {
            Rol rolPaciente = null;
            String nombrePaciente = "ADMIN";
            try
            {
                var query = from it in context.Rols
                    where it.RolNombre == nombrePaciente
                    select it;
                foreach (Rol ROLLista in query)
                {
                    rolPaciente = ROLLista;
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
