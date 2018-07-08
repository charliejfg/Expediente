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
        public int CrearPersona(String apellidoUno, String apellidoDos, String nombre, String cedula, String telefono, String correo, String clave, bool entrada)
        {
            int respuesta;
            try
            {
                // Create a new category
                Persona nuevaPersona = new Persona();
                nuevaPersona.Nombre = nombre;
                nuevaPersona.ApellidoUno = apellidoUno;
                nuevaPersona.ApellidoDos = apellidoDos;
                nuevaPersona.Cedula = cedula;
                nuevaPersona.Telefono = telefono;
                nuevaPersona.Correo = correo;
                nuevaPersona.Clave = clave;
                nuevaPersona.Entrada = entrada;

                Rol nuevoRol = PersonaPacienteDatos.TraerRolPaciente();

                PersonaRol nuevoPacienteRol = new PersonaRol();
                nuevoPacienteRol.Persona = nuevaPersona;
                nuevoPacienteRol.Rol = nuevoRol;

                respuesta = PersonaPacienteDatos.CrearPaciente(nuevaPersona, nuevoRol , nuevoPacienteRol );
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        
    }
}
