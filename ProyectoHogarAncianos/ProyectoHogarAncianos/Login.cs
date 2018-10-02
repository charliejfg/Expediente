using System;
using HjaContext;
using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoHogarAncianosEntidades;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            
            PersonaLogica nuevaLogica = new PersonaLogica();
            Persona posiblePersona = nuevaLogica.entradaPersona(materialSingleLineTextField1.Text, materialSingleLineTextField2.Text);
            if (posiblePersona == null)
            {
                //hacer que msj se muestre con el error, o en este caso una clave incorrecta
            }
            else
            {
                PersonaLogeada claseEncargado = new PersonaLogeada(posiblePersona);
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.ShowDialog();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //Encryptado pagina = new Encryptado();
            //Hide();
            //pagina.ShowDialog();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            RecetasReporte reporte = new RecetasReporte();
            Hide();
            reporte.ShowDialog();
        }
    }
}
