using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosEntidades
{
    public class Citas
    {
        public int id { get; set; }
        public int idPaciente { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
    }
}
