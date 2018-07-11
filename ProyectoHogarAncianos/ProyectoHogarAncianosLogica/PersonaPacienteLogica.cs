using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HjaContext;
using ProyectoHogarAncianosDatos;

namespace ProyectoHogarAncianosLogica
{
    public class PersonaPacienteLogica
    {
        public int CrearPersona(String apellidoUno, String apellidoDos, String nombre, String cedula )
        {
            Persona nuevaPersona= null;
            PersonaDatos datos = new PersonaDatos();
            int existePersona = datos.ExistePersona(cedula);
            int respuesta;
            try
            {
                if (existePersona == 1)
                {
                    // Create a new category
                    nuevaPersona = new Persona();
                    nuevaPersona.Nombre = nombre;
                    nuevaPersona.ApellidoUno = apellidoUno;
                    nuevaPersona.ApellidoDos = apellidoDos;
                    nuevaPersona.Cedula = cedula;
                    nuevaPersona.Telefono = " ";
                    nuevaPersona.Correo = " ";
                    nuevaPersona.Clave = " ";
                    nuevaPersona.Entrada = false;

                    Rol nuevoRol = PersonaPacienteDatos.TraerRolPaciente();

                    PersonaRol nuevoPacienteRol = new PersonaRol();
                    nuevoPacienteRol.Persona = nuevaPersona;
                    nuevoPacienteRol.Rol = nuevoRol;
                    respuesta = PersonaPacienteDatos.CrearPaciente(nuevaPersona, nuevoRol, nuevoPacienteRol);
                }
                else
                {
                    return 2;
                }
            }
            catch (Exception)
            {
                return 1;
            }
            return 0;
        }

        
    }
}
