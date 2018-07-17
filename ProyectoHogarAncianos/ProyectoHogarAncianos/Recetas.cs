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
using HjaContext;
using ProyectoHogarAncianosEntidades;

namespace ProyectoHogarAncianos
{
    public partial class Recetas : MaterialForm
    {
        private Persona Encargado = null;
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
            PersonaLogica personaLogica = new PersonaLogica();
            List<Persona> ListaPacientes = personaLogica.TraerPacientes(); 

            cboPacientes.DataSource = ListaPacientes;
            cboPacientes.DisplayMember = "nombre";
            cboPacientes.ValueMember = "id";

            DateTime Hoy = DateTime.Today;
            txtFecha.Text = Convert.ToString(Hoy);

            Encargado = PersonaLogeada.GetInstance();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            RecetaLogica recetaLogica = new RecetaLogica();
            int resultado = recetaLogica.CrearReceta(Convert.ToInt32(Encargado.Id), Convert.ToInt32(cboPacientes.SelectedValue), DateTime.Parse(txtFecha.Text));
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
            PersonaLogica personaLogica = new PersonaLogica();
            List<Persona> ResultadoPacientes = personaLogica.BuscarPacientes(txtBuscar.Text);

            cboPacientes.DataSource = ResultadoPacientes;
            cboPacientes.DisplayMember = "nombre";
            cboPacientes.ValueMember = "id";
        }
    }
}
