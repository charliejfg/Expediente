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

namespace ProyectoHogarAncianos
{
    public partial class Administracion : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Administracion()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Administracion_Load(object sender, EventArgs e)
        {

            listView1.Items.Add("Carlos Fernadez Garcia", 0);
            listView1.Items[0].SubItems.Add("Hombre");
            listView1.Items.Add("Georgi Mesen Cerdas", 0);
            listView1.Items[1].SubItems.Add("Hombre");
            listView1.Items.Add("Pedro Ramos Llano", 0);
            listView1.Items[2].SubItems.Add("Hombre");
            listView1.Items.Add("Andres Cordero Ruiz", 0);
            listView1.Items[3].SubItems.Add("Hombre");
            listView1.Items.Add("Marco Perez Gomez", 0);
            listView1.Items[4].SubItems.Add("Hombre");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
