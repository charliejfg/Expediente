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
        public int idActividad = -1;
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
            if (actividad != null)
            {
                txtActividad.Text = actividad.Actividad;
                txaDescripcion.Text = actividad.Descripcion;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int posiblePersona = 1;
            if (idActividad != -1)
            {
                posiblePersona = actividadLogica.ModificarActividad(idActividad, txtActividad.Text, txaDescripcion.Text);
            }
            else
            {

                posiblePersona = actividadLogica.CrearActividad(txtActividad.Text, txaDescripcion.Text);
            }
            if (posiblePersona == 0)
            {
                MessageBox.Show(@"Actividad guardada");
                Administracion movimientoPagina = new Administracion();
                Close();
                Hide();
                movimientoPagina.ShowDialog();
            }
            else
            {
                if (posiblePersona == 1)
                {
                    MessageBox.Show(@"Error de sistema por favor, intente de nuevo");
                }
                else
                {
                    MessageBox.Show(@"Actividad ya existente por favor intente otra");
                }
            }
        }
    }
}
