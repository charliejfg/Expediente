using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using ProyectoHogarAncianosLogica;
using HjaContext;

namespace ProyectoHogarAncianos
{
    public partial class Actividades : MaterialForm
    {
        public int idActividad;
        ActividadLogica actividadLogica = new ActividadLogica();
        public Actividades()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            Actividade actividad = actividadLogica.TraerActividadPorId(idActividad);
            txtActividad.Text = actividad.Actividad;
            txaDescripcion.Text = actividad.Descripcion;
        }
    }
}
