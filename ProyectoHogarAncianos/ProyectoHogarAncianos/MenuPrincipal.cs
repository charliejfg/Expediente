using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HjaContext;
using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoHogarAncianosEntidades;

namespace ProyectoHogarAncianos
{
    public partial class MenuPrincipal : MaterialForm
    {
        private Persona personaNueva;
        public MenuPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //
            //
            //Agregar datos del encargado logeado en los lavels afuera con la clase global PersonaLogeada
            personaNueva = PersonaLogeada.GetInstance();

            nombreTitulo.Text = string.Format("{0} {1} {2}", personaNueva.Nombre, personaNueva.ApellidoUno, personaNueva.ApellidoDos);

            //
            //
            //

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
            RecetaPaciente re = new RecetaPaciente();
            re.StartPosition = FormStartPosition.CenterScreen;
            re.ShowDialog();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Administracion menu = new Administracion();
            this.Hide();
            menu.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            Expediente nuevaPagina = new Expediente();
            Hide();
            nuevaPagina.ShowDialog();
        }
    }
}
