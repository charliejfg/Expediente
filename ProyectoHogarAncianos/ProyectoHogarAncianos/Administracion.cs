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
            //Se llena la listview de pacientes
            LstPacientes.Items.Add("Carlos Fernadez Garcia", 0);
            LstPacientes.Items[0].SubItems.Add("Hombre");
            LstPacientes.Items[0].SubItems.Add("1");
            LstPacientes.Items.Add("Georgi Mesen Cerdas", 0);
            LstPacientes.Items[1].SubItems.Add("Hombre");
            LstPacientes.Items[1].SubItems.Add("2");
            LstPacientes.Items.Add("Pedro Ramos Llano", 0);
            LstPacientes.Items[2].SubItems.Add("Hombre");
            LstPacientes.Items[2].SubItems.Add("3");
            LstPacientes.Items.Add("Andres Cordero Ruiz", 0);
            LstPacientes.Items[3].SubItems.Add("Hombre");
            LstPacientes.Items[3].SubItems.Add("4");
            LstPacientes.Items.Add("Marco Perez Gomez", 0);
            LstPacientes.Items[4].SubItems.Add("Hombre");
            LstPacientes.Items[4].SubItems.Add("5");

            //Se llena la listview de actividades
            LstActividades.Items.Add("Ejercicio");
            LstActividades.Items.Add("Pasear");
            LstActividades.Items.Add("Manualidades");

            //Se llena la listview de medicamentos
            LstMedicamentos.Items.Add("Morfina");
            LstMedicamentos.Items[0].SubItems.Add("Anestésicos");
            LstMedicamentos.Items.Add("Paracetamol");
            LstMedicamentos.Items[1].SubItems.Add("Antiinflamatorios");
            LstMedicamentos.Items.Add("Fenobarbital");
            LstMedicamentos.Items[2].SubItems.Add("Anticonvulsivo");

            //Se llena la listview de recetas
            LstRecetas.Items.Add("1");
            LstRecetas.Items[0].SubItems.Add("Andres Cordero Ruiz");
            LstRecetas.Items.Add("2");
            LstRecetas.Items[1].SubItems.Add("Marco Perez Gomez");
            LstRecetas.Items.Add("3");
            LstRecetas.Items[2].SubItems.Add("Pedro Ramos Llano");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            Expediente expediente = new Expediente();
            expediente.Show();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            Medicamentos meds = new Medicamentos();
            meds.Show();
        }
    }
}
