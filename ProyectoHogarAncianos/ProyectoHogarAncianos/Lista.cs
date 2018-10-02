using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HjaContext;
using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Lista : MaterialForm
    {
        private long pacienteId;

        public Lista(long pacienteId)
        {
            InitializeComponent();
            this.pacienteId = pacienteId;
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

        private void Lista_Load(object sender, EventArgs e){
            List<Receta> listaReceta = traerTodas(pacienteId);
            foreach (Receta receta in listaReceta)
            {
                dataGridView1.Rows.Add(receta.Id, receta.Fecha);
            }

        }

        public List<Receta> traerTodas(long pacienteId){
            RecetaLogica recetaDatos = new RecetaLogica();
            List<Receta> listaReceta = recetaDatos.TraerRecetasPorPaciente(pacienteId);

            return listaReceta;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            RecetaLogica recetaDatos = new RecetaLogica();
            List<Receta> listaReceta =
                recetaDatos.TraerRecetasFiltradoPorPaciente(pacienteId, dateTimePicker1.Value, dateTimePicker2.Value);
            foreach (Receta receta in listaReceta)
            {
                dataGridView1.Rows.Add(receta.Id, receta.Fecha);
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            List<Receta> listaReceta = traerTodas(pacienteId);
            foreach (Receta receta in listaReceta){
                dataGridView1.Rows.Add(receta.Id, receta.Fecha);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
            DataGridViewRow row = dataGridView1.CurrentRow;
            long id = (long)Convert.ToInt32(row.Cells[0].Value);
            RecetasReporte nuevaVista = new RecetasReporte(id);
            Hide();
            nuevaVista.ShowDialog();

        }
    }
}
