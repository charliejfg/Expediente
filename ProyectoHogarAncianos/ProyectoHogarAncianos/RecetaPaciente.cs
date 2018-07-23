using HjaContext;
using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoHogarAncianosLogica;
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
    public partial class RecetaPaciente : MaterialForm
    {
        PersonaLogica personaLogica = new PersonaLogica();
        public RecetaPaciente()
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

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se cambian los datos dependiendo del paciente que se escoja
            Persona persona = new Persona();
            String cedula = Convert.ToString(cboPaciente.SelectedValue);
            persona = personaLogica.TraerPacientePorCedula(cedula);

            if (persona != null)
            {
                lblCedula.Text = persona.Cedula;
                lblNombre.Text = persona.Nombre;
                lblApellido.Text = persona.ApellidoUno + " " + persona.ApellidoDos;
            }
        }

        private void RecetaPaciente_Load(object sender, EventArgs e)
        {
            //Se llena el combo box de pacientes
            List<Persona> ListaPacientes = personaLogica.TraerPacientes();
            cboPaciente.DataSource = ListaPacientes;
            cboPaciente.DisplayMember = "nombre";
            cboPaciente.ValueMember = "cedula";
        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            List<Persona> ResultadoPacientes = personaLogica.BuscarPacientes(txtBuscarPaciente.Text);

            cboPaciente.DataSource = ResultadoPacientes;
            cboPaciente.DisplayMember = "nombre";
            cboPaciente.ValueMember = "cedula";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Recetas re = new Recetas();
            re.StartPosition = FormStartPosition.CenterScreen;
            re.cedula = Convert.ToString(cboPaciente.SelectedValue);
            re.ShowDialog();
        }
    }
}
