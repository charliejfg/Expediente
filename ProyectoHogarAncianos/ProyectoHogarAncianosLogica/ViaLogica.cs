using HjaContext;
using ProyectoHogarAncianosDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHogarAncianosLogica
{
    public class ViaLogica
    {
        public List<Via> TraerVias()
        {
            ViaDatos viaDatos = new ViaDatos();
            List<Via> ListaVia = new List<Via>();

            ListaVia = viaDatos.TraerVias();

            return ListaVia;
        }

        public Via TraerViaPorId(int idVia)
        {
            ViaDatos viaDatos = new ViaDatos();
            Via via = new Via();

            via = viaDatos.TraerViaPorId(idVia);

            return via;
        }
    }
}
