using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHogarAncianos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
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
    }
}
