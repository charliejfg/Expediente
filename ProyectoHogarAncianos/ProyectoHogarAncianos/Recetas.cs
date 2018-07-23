using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using ProyectoHogarAncianosLogica;
using HjaContext;
using ProyectoHogarAncianosEntidades;

namespace ProyectoHogarAncianos
{
    public partial class Recetas : MaterialForm
    {
        private Persona Encargado = null;
        public String cedula = null;
        PersonaLogica personaLogica = new PersonaLogica();
        Persona paciente = new Persona();
        ViaLogica viaLogica = new ViaLogica();
        MedicamentoLogica medicamentoLogica = new MedicamentoLogica();
        public Recetas()
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

        private void Recetas_Load(object sender, EventArgs e)
        {
            //Se busca el paciente y se guarda en una variable
            paciente = personaLogica.TraerPacientePorCedula(cedula);
            lblPaciente.Text = paciente.Cedula + "-" + paciente.Nombre + " " + paciente.ApellidoUno + " " + paciente.ApellidoDos;
            //Se coloca la fecha de hoy
            DateTime Hoy = DateTime.Now;
            txtFecha.Text = Hoy.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);


            Encargado = PersonaLogeada.GetInstance();
            //Se llenan la vias
            cboVia.DataSource = viaLogica.TraerVias();
            cboVia.DisplayMember = "descripcion";
            cboVia.ValueMember = "id";
            //Se llena los medicamentos
            cboMedicamento.DataSource = medicamentoLogica.TraerMedicamentos();
            cboMedicamento.DisplayMember = "descripcion";
            cboMedicamento.ValueMember = "id";
            //Oculta columnas de id
            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[3].Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            RecetaLogica recetaLogica = new RecetaLogica();
            List<RecetaDetalle> detalleReceta = new List<RecetaDetalle>();
            //Se recorre la datagridview
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                RecetaDetalle detalle = new RecetaDetalle();
                detalle.MedicamentoId = Convert.ToInt32(row.Cells[0].Value);
                detalle.ViaId = Convert.ToInt32(row.Cells[3].Value);
                detalle.Frecuencia = row.Cells[5].Value.ToString();
                detalle.Fecha = DateTime.Parse(txtFecha.Text);
                detalleReceta.Add(detalle);
            }

            int resultado = recetaLogica.CrearReceta(Convert.ToInt32(Encargado.Id), Convert.ToInt32(paciente.Id), DateTime.Parse(txtFecha.Text), detalleReceta);
            if (resultado == 0)
            {
                MessageBox.Show(@"Receta guardado");

            }
            else
            {
                if (resultado == 1)
                {
                    MessageBox.Show(@"Error de sistema por favor, intente de nuevo");
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Medicamento> resultados = medicamentoLogica.buscarMedicamentos(txtBuscar.Text);
            cboMedicamento.DataSource = resultados;
            cboMedicamento.DisplayMember = "descripcion";
            cboMedicamento.ValueMember = "id";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Medicamento med = medicamentoLogica.TraerMedicamentoPorId(Convert.ToInt32(cboMedicamento.SelectedValue));
            Via via = viaLogica.TraerViaPorId(Convert.ToInt32(cboVia.SelectedValue));
            //Agrega filas
            dgvDetalle.Rows.Add(med.Id,med.Codigo,med.Descripcion,via.Id,via.Descripcion,txtFrecuencia.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se elimina la fila seleccionada
            dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
        }

        private void txtFecha_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
