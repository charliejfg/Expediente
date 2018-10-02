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
using MaterialSkin.Controls;
using MaterialSkin;
using ProyectoHogarAncianosEntidades;

namespace ProyectoHogarAncianos
{
    public partial class Expediente : MaterialForm
    {
        private Persona personaNueva = null;
        public Expediente()
        {
            InitializeComponent();
            this.CenterToScreen();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //
            //
            //Agregar datos del encargado logeado en los lavels afuera con la clase global PersonaLogeada
            personaNueva = PersonaLogeada.GetInstance();

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

        private void Expediente_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Pacientee nuevoMenu = new Pacientee();
            Hide();
            nuevoMenu.ShowDialog();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MenuPrincipal nuevo = new MenuPrincipal();
            Hide();
            Close();
            nuevo.ShowDialog();
        }
    }
}
