using HjaContext;
using ProyectoHogarAncianosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosLogica
{
    public class MedicamentoLogica
    {
        public int CrearMedicamento(String codigo, String descripcion, int peso)
        {
            MedicamentoDatos nuevoDatos = new MedicamentoDatos();
            int respuesta;
            try
            {
                // Create a new category
                Medicamento nuevaMedicamento = new Medicamento();
                nuevaMedicamento.Descripcion = descripcion;
                nuevaMedicamento.Codigo = codigo;
                nuevaMedicamento.Peso = peso;


                respuesta = nuevoDatos.CrearMedicamento(nuevaMedicamento);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }

        public int ModificarMedicamento(int idMedicamento, String descripcion, String codigo, int peso)
        {
            MedicamentoDatos nuevoDatos = new MedicamentoDatos();
            int respuesta;
            try
            {
                // Create a new category
                Medicamento nuevaMedicamento = new Medicamento();
                nuevaMedicamento.Id = idMedicamento;
                nuevaMedicamento.Descripcion = descripcion;
                nuevaMedicamento.Codigo = codigo;
                nuevaMedicamento.Peso = peso;

                respuesta = nuevoDatos.ModificarMedicamento(nuevaMedicamento);
            }
            catch (Exception)
            {
                return 1;
            }
            return respuesta;
        }
        public List<Medicamento> TraerMedicamentos()
        {
            MedicamentoDatos medicamentoDatos = new MedicamentoDatos();
            List<Medicamento> ListaMedicamento = new List<Medicamento>();

            ListaMedicamento = medicamentoDatos.TraerMedicamentos();

            return ListaMedicamento;
        }

        public Medicamento TraerMedicamentoPorId(int idMedicamento)
        {
            MedicamentoDatos medicamentoDatos = new MedicamentoDatos();
            Medicamento Medicamento = new Medicamento();

            Medicamento = medicamentoDatos.TraerMedicamentoPorId(idMedicamento);

            return Medicamento;
        }

        public List<Medicamento> buscarMedicamentos(String buscar)
        {
            MedicamentoDatos medicamentoDatos = new MedicamentoDatos();
            List<Medicamento> ListaMedicamento = new List<Medicamento>();

            ListaMedicamento = medicamentoDatos.buscarMedicamentos(buscar);

            return ListaMedicamento;
        }
    }
}
