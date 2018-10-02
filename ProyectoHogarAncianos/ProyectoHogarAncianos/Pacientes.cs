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
using ProyectoHogarAncianosEntidades;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Pacientes : MaterialForm
    {
        public int idPaciente = -1;
        PacienteLogica pacienteLogica = new PacienteLogica();
        public Pacientes()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            cboGenero.DataSource = Enum.GetValues(typeof(ClaseGenero.Generos));

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

         private void Pacientes_Load(object sender, EventArgs e)
        {
            dtpFechaNac.Format = DateTimePickerFormat.Custom;
            dtpFechaNac.CustomFormat = "dd/MM/yyyy";

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("F", "Femenino");
            comboSource.Add("M", "Masculino");

            cboGenero.DataSource = new BindingSource(comboSource, null);
            cboGenero.DisplayMember = "Value";
            cboGenero.ValueMember = "Key";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int posiblePersona = 1;
            if (idPaciente != -1)
            {
                posiblePersona = pacienteLogica.ModificarPaciente(idPaciente,txtCedula.Text,
                    txtNombre.Text,
                    txtApellido1.Text,
                    txtApellido2.Text,
                    dtpFechaNac.Value,
                    Convert.ToInt32(txtPeso.Text),
                    Convert.ToString(cboGenero.SelectedValue),
                    Convert.ToInt32(txtAltura.Text));
            }
            else
            {

                posiblePersona = pacienteLogica.CrearPaciente(txtCedula.Text,
                    txtNombre.Text,
                    txtApellido1.Text,
                    txtApellido2.Text,
                    dtpFechaNac.Value,
                    Convert.ToInt32(txtPeso.Text),
                    Convert.ToString(cboGenero.SelectedValue),
                    Convert.ToInt32(txtAltura.Text));
            }
            if (posiblePersona == 0)
            {
                MessageBox.Show(@"Paciente guardado");
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
