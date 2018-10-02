using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosEntidades
{
    public class DetalleRecetaFavorita
    {
        public int id { get; set; }
        public int receta_id{ get; set; }
        public int medicamento_id { get; set; }
        public int via_id { get; set; }
        public string frecuencia { get; set; }
        public DateTime fecha { get; set; } 
    }
}
