using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProyectoHogarAncianos
{
    public partial class MenuPrincipal : MaterialForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
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

        private void crearExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();
            pacientes.ShowDialog();
        }

        private void crearRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Administracion menu = new Administracion();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
