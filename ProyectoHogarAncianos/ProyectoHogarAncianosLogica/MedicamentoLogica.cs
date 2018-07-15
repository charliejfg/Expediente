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

    }
}
