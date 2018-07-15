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
            List<Medicamento> ListaMedicamento = null;
            try
            {
                var query = from it in context.Medicamentos
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
