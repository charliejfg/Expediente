using System;
using HjaContext;
using ProyectoHogarAncianosDatos;

namespace ProyectoHogarAncianosLogica
{
    public class PersonaLogica
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


                respuesta  = PersonaDatos.CrearPersona(nuevaPersona);
            }catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public Persona entradaPersona(String nombre, String clave)
        {
            int existePersona = PersonaDatos.ExistePersona(nombre);

            if (existePersona == 0){

            }
            else{
                if (existePersona == 1)
                {

                }
            }
            return respuesta;
        } 
    }
}
