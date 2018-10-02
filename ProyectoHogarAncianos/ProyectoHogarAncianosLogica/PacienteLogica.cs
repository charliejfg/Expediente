using HjaContext;
using ProyectoHogarAncianosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosLogica
{
    public class PacienteLogica
    {
        public int CrearPaciente(String cedula, String nombre, String apellido1, String apellido2,DateTime fechaNac,
            int peso,String genero,int altura)
        {
            PacienteDatos nuevoDatos = new PacienteDatos();
            int respuesta;
            try
            {
                // Create a new category
                Paciente nuevaPaciente = new Paciente();
                nuevaPaciente.Cedula = cedula;
                nuevaPaciente.Nombre = nombre;
                nuevaPaciente.Apellido1 = apellido1;
                nuevaPaciente.Apellido2 = apellido2;
                nuevaPaciente.FechaNacimiento = fechaNac;
                nuevaPaciente.Peso = peso;
                nuevaPaciente.Genero = genero;
                nuevaPaciente.Altura = altura;


                respuesta = nuevoDatos.CrearPaciente(nuevaPaciente);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public int ModificarPaciente(int idPaciente, String cedula, String nombre, String apellido1, String apellido2, 
            DateTime fechaNac,int peso, String genero, int altura)
        {
            PacienteDatos nuevoDatos = new PacienteDatos();
            int respuesta;
            try
            {
                // Create a new category
                Paciente nuevaPaciente = new Paciente();
                nuevaPaciente.Id = idPaciente;
                nuevaPaciente.Cedula = cedula;
                nuevaPaciente.Nombre = nombre;
                nuevaPaciente.Apellido1 = apellido1;
                nuevaPaciente.Apellido2 = apellido2;
                nuevaPaciente.FechaNacimiento = fechaNac;
                nuevaPaciente.Peso = peso;
                nuevaPaciente.Genero = genero;
                nuevaPaciente.Altura = altura;

                respuesta = nuevoDatos.ModificarPaciente(nuevaPaciente);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public List<Paciente> TraerPaciente()
        {
            PacienteDatos PacienteDatos = new PacienteDatos();
            List<Paciente> ListaPaciente = new List<Paciente>();

            ListaPaciente = PacienteDatos.TraerPacientes();

            return ListaPaciente;
        }

        public Paciente TraerPacientePorId(int idPaciente)
        {
            PacienteDatos PacienteDatos = new PacienteDatos();
            Paciente Paciente = new Paciente();

            Paciente = PacienteDatos.TraerPacientePorId(idPaciente);

            return Paciente;
        }

        public List<Paciente> BuscarPaciente(String buscarPaciente)
        {
            PacienteDatos PacienteDatos = new PacienteDatos();
            List<Paciente> ListaPaciente = new List<Paciente>();

            ListaPaciente = PacienteDatos.buscarPacientes(buscarPaciente);

            return ListaPaciente;
        }
    }
}
