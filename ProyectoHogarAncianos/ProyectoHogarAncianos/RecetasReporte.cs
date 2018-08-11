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
using Microsoft.Reporting.WinForms;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class RecetasReporte : Form
    {
        private long idReceta;
        private RecetaLogica recetaDatos;
        public RecetasReporte(long idReceta)
        {
            this.idReceta = idReceta;
            InitializeComponent();
        }

        private void RecetasReporte_Load(object sender, EventArgs e)
        {
            recetaDatos = new RecetaLogica();
            PersonaLogica personaLogica = new PersonaLogica();
            List<RecetaDetalle> lista = recetaDatos.traerRecetaDetallePorRecetaId(idReceta);
            Persona paciente = recetaDatos.TraerPacientePorReceta(idReceta);
            Receta receta = recetaDatos.TraerRecetasPorId(idReceta);
            String nombreCompleto = paciente.Nombre + " " + paciente.ApellidoUno + " " + paciente.ApellidoDos;
            if (lista != null) reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lista));
            this.reportViewer1.LocalReport.SetParameters(
                new Microsoft.Reporting.WinForms.ReportParameter("Nombre", nombreCompleto));
            this.reportViewer1.LocalReport.SetParameters(
                new Microsoft.Reporting.WinForms.ReportParameter("Cedula", paciente.Cedula));
            this.reportViewer1.LocalReport.SetParameters(
                new Microsoft.Reporting.WinForms.ReportParameter("Fecha", receta.Fecha.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
