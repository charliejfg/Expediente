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
    public partial class RecetasReporte : Form
    {
        private long idReceta;
        public RecetasReporte(/*int idReceta*/)
        {
            //this.idReceta = idReceta;
            InitializeComponent();
        }

        private void RecetasReporte_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(
                new Microsoft.Reporting.WinForms.ReportParameter("idReceta","1"));
            this.reportViewer1.RefreshReport();
        }
    }
}
