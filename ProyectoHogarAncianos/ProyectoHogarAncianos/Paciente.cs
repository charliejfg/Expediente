using System;
using System.Windows.Forms;
using HjaContext;
using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoHogarAncianosEntidades;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Paciente : MaterialForm
    {
        private Persona _personaNueva = null;
        public Paciente()
        {
            InitializeComponent();
            CenterToScreen();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            //
            //
            //Agregar datos del encargado logeado en los lavels afuera con la clase global PersonaLogeada
            _personaNueva = PersonaLogeada.GetInstance();

            //
            //
            //

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            PersonaPacienteLogica nuevaLogica = new PersonaPacienteLogica();
            int posiblePersona = nuevaLogica.CrearPersona(cedula: materialSingleLineTextField1.Text, nombre: materialSingleLineTextField2.Text, apellidoUno: materialSingleLineTextField3.Text, apellidoDos: materialSingleLineTextField4.Text);
            if (posiblePersona == 0)
            {
                MessageBox.Show(@"Paciente guardado");

            }
            else
            {
                if (posiblePersona == 1)
                {
                    MessageBox.Show(@"Error de sistema por favor, intente de nuevo");
                    materialSingleLineTextField1.Text = "";
                    materialSingleLineTextField2.Text = "";
                    materialSingleLineTextField3.Text = "";
                    materialSingleLineTextField4.Text = "";
                }
                else
                {
                    MessageBox.Show(@"Cedula ya existente por favor intente otra");
                    materialSingleLineTextField1.Text = "";
                    materialSingleLineTextField2.Text = "";
                    materialSingleLineTextField3.Text = "";
                    materialSingleLineTextField4.Text = "";
                }
            }


            
        }
    }
}
