using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Medicamentos : MaterialForm
    {
        public int idMedicamento = -1;
        MedicamentoLogica MedicamentoLogica = new MedicamentoLogica();
        public Medicamentos()
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

        private void Medicamentos_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int posiblePersona = 1;
            if (idMedicamento != -1)
            {
                posiblePersona = MedicamentoLogica.ModificarMedicamento(idMedicamento,txtCodigo.Text,
                    txtNombre.Text, Convert.ToInt32(txtPeso.Text));
            }
            else
            {

                posiblePersona = MedicamentoLogica.CrearMedicamento(txtCodigo.Text,txtNombre.Text,Convert.ToInt32(txtPeso.Text));
            }
            if (posiblePersona == 0)
            {
                MessageBox.Show(@"Medicamento guardado");
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
