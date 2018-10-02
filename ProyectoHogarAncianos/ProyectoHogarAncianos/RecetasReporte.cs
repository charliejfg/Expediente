using Microsoft.Reporting.WinForms;
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
            List<string[]> list = new List<string[]>();
            //list.Add(new string[] { "Fecha", "Id", "Nombre" });
            list.Add(new string[] { "116620079", "70", "06/08/2018", "Rodrigo Brenes",
                "Antibioticos 1 capsula cada 12 Horas", "N", "N" });

            // Convert to DataTable.
            DataTable table = ConvertListToDataTable(list);
            ReportDataSource rprtDTSource = new ReportDataSource();
            rprtDTSource.Name = "DataSet1";
            rprtDTSource.Value = table;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(
                new Microsoft.Reporting.WinForms.ReportParameter("idReceta","1"));
            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.RefreshReport();
        }

        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            //for (int i = 0; i < columns; i++)
            //{
            table.Columns.Add("Cedula");
            table.Columns.Add("Edad");
            table.Columns.Add("Fecha");
            table.Columns.Add("Nombre");
            table.Columns.Add("Receta1");
            table.Columns.Add("Receta2");
            table.Columns.Add("Receta3");
            //}

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }
    }
}
