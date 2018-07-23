using HjaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosDatos
{
    public class MedicamentoDatos
    {

        private HjaDataContext context = new HjaDataContext();

        public Medicamento TraerMedicamentoPorId(int idMedicamento)
        {
            Medicamento Medicamento = null;
            try
            {
                var query = from it in context.Medicamentos
                            where it.Id == idMedicamento
                            select it;
                foreach (Medicamento MedicamentoLista in query)
                {
                    Medicamento = MedicamentoLista;
                }
            }
            catch (Exception)
            {
                return null;
            }

            return Medicamento;
        }

        public List<Medicamento> TraerMedicamentos()
        {
            List<Medicamento> ListaMedicamento = new List<Medicamento>();
            try
            {
                var query = from it in context.Medicamentos
                            select it;
                foreach (Medicamento MedicamentoLista in query)
                {
                    ListaMedicamento.Add(MedicamentoLista);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            return ListaMedicamento;
        }

        public List<Medicamento> buscarMedicamentos(String buscar)
        {
            List<Medicamento> ListaMedicamento = new List<Medicamento>();
            try
            {
                var query = from it in context.Medicamentos
                            where (it.Descripcion.Contains(buscar) || it.Codigo.Contains(buscar))
                            select it;
                foreach (Medicamento MedicamentoLista in query)
                {
                    ListaMedicamento.Add(MedicamentoLista);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return ListaMedicamento;
        }
    }
}
