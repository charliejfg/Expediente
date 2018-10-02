using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosEntidades
{
    public class RecetaFavorita
    {
        public int id { get; set; }
        public int encargado_id{ get; set; }
        public int pam_id { get; set; }
        public DateTime fecha { get; set; }

    }
}
