using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ListaExpediente : MaterialForm
    {
        public ListaExpediente()
        {
            InitializeComponent();
            this.CenterToScreen();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosExpediente de = new DatosExpediente();
            de.ShowDialog();
        }

        private void ListaExpediente_Load(object sender, EventArgs e)
        {
            materialListView1.Items.Add("1");
            materialListView1.Items[0].SubItems.Add("116620079");
            materialListView1.Items[0].SubItems.Add("Andres Cordero Ruiz");
        }
    }
}
