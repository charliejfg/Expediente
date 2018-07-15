using System;
using HjaContext;
using ProyectoHogarAncianosDatos;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace ProyectoHogarAncianosLogica
{
    public class PersonaLogica
    {
        public int CrearPersona(String apellidoUno, String apellidoDos, String nombre, String cedula, String telefono, String correo, String clave, bool entrada)
        {
            PersonaDatos nuevoDatos = new PersonaDatos();
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

                Rol nuevoRol = nuevoDatos.TraerRolAdmin();

                PersonaRol nuevoPacienteRol = new PersonaRol();
                nuevoPacienteRol.Persona = nuevaPersona;
                nuevoPacienteRol.Rol = nuevoRol;

                respuesta = nuevoDatos.CrearPersona(nuevaPersona, nuevoRol, nuevoPacienteRol);
            }catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public Persona entradaPersona(String nombre, String clave)
        {
            PersonaDatos nuevoDatos = new PersonaDatos();
            int existePersona = nuevoDatos.ExistePersona(nombre);
            Persona usuarioPorNombre = null;
            if (existePersona == 0)
            {
                usuarioPorNombre = nuevoDatos.TrearPersonaPorCedula(nombre);
                if (usuarioPorNombre.Clave.Equals(getClaveEncriptada(clave)))
                {
                    return usuarioPorNombre;
                }
                else
                {
                    return null;
                }
            }
            else{
                if (existePersona == 1)
                {
                    return null;
                }
            }
            return null;
        }


        public String getClaveEncriptada(String clave)
        {
            MD5CryptoServiceProvider newProvider = new MD5CryptoServiceProvider();
            newProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(clave));
            byte[] clavehasheada = newProvider.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < clavehasheada.Length; i++)
            {
                str.Append(clavehasheada[i].ToString("x2"));
            }
            return str.ToString();
        }

        public Persona TraerPacientePorCedula(String cedula)
        {
            PersonaDatos personaDatos = new PersonaDatos();
            Persona Persona = new Persona();

            Persona = personaDatos.TrearPacientePorCedula(cedula);

            return Persona;
        }

        public List<Persona> TraerPacientes()
        {
            PersonaDatos personaDatos = new PersonaDatos();
            List<Persona> ListaPersonas = new List<Persona>();

            ListaPersonas = personaDatos.TraerPacientes();

            return ListaPersonas;
        }
    }
}
