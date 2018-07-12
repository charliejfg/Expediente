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
    public partial class ReporteReceta : Form
    {
        public ReporteReceta()
        {
            InitializeComponent();
        }

        private void ReporteReceta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
