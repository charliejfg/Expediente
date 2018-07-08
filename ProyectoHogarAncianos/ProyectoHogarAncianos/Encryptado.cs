using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Encryptado : MaterialForm
    {
        public Encryptado()
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

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaLogica nuevaLogica = new PersonaLogica();
            txtEncrypt.Text = nuevaLogica.getClaveEncriptada(txtClave.Text);
        }

        private void Encryptado_Load(object sender, EventArgs e)
        {

        }
    }
}
