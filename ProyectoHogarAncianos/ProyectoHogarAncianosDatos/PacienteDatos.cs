using HjaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosDatos
{
    public class PacienteDatos
    {
        private HjaDataContext context = new HjaDataContext();

        public int CrearPaciente(Paciente pacienteNuevo)
        {
            try
            {
                context.Pacientes.InsertOnSubmit(pacienteNuevo);
                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public int ModificarPaciente(Paciente pacienteNuevo)
        {
            try
            {
                var query = (from it in context.Pacientes
                             where it.Id == pacienteNuevo.Id
                             select it).FirstOrDefault();
                query.Cedula = pacienteNuevo.Cedula;
                query.Nombre = pacienteNuevo.Nombre;
                query.Apellido1 = pacienteNuevo.Apellido1;
                query.Apellido2 = pacienteNuevo.Apellido2;
                query.FechaNacimiento = pacienteNuevo.FechaNacimiento;
                query.Peso = pacienteNuevo.Peso;
                query.Genero = pacienteNuevo.Genero;
                query.Altura = pacienteNuevo.Altura;

                context.SubmitChanges();
            }
            catch (Exception)
            {
                return 2;
            }
            return 0;
        }

        public Paciente TraerPacientePorId(int idPaciente)
        {
            Paciente Paciente = null;
            try
            {
                var query = from it in context.Pacientes
                            where it.Id == idPaciente
                            select it;
                foreach (Paciente PacienteLista in query)
                {
                    Paciente = PacienteLista;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return Paciente;
        }

        public List<Paciente> TraerPacientes()
        {
            List<Paciente> ListaPaciente = new List<Paciente>();
            try
            {
                var query = from it in context.Pacientes
                            select it;
                foreach (Paciente pacienteLista in query)
                {
                    ListaPaciente.Add(pacienteLista);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return ListaPaciente;
        }

        public List<Paciente> buscarPacientes(String buscar)
        {
            List<Paciente> ListaPaciente = new List<Paciente>();
            try
            {
                var query = from it in context.Pacientes
                            where (it.Cedula.Contains(buscar) || it.Nombre.Contains(buscar))
                            select it;
                foreach (Paciente PacienteLista in query)
                {
                    ListaPaciente.Add(PacienteLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaPaciente;
        }
    }
}
