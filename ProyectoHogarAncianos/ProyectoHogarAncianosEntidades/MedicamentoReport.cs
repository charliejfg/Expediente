using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HjaContext;

namespace ProyectoHogarAncianosEntidades
{
    public class MedicamentoReport
    {
        public long _id;
        public long _recetaId;
        public String _nombreMedicamento;
        public String _nombreVia;
        public String _frecuencia;
        public DateTime _fecha;

        public void objectToVO(RecetaDetalle recetaDetalle)
        {
            this._id = recetaDetalle.Id;
            this._recetaId = recetaDetalle.RecetaId;
            this._nombreMedicamento = recetaDetalle.Medicamento.Descripcion;
            this._nombreVia = recetaDetalle.Via.Descripcion;
            this._frecuencia = recetaDetalle.Frecuencia;
            if (recetaDetalle.Fecha != null) this._fecha = (DateTime) recetaDetalle.Fecha;
        }
    }
}
