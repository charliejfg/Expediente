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

            //Se llena la listview de expedientes
            LstExpediente.Items.Add("116620079");
            LstExpediente.Items[0].SubItems.Add("Andres Cordero Ruiz");
            LstExpediente.Items.Add("202947575");
            LstExpediente.Items[1].SubItems.Add("Marco Perez Gomez");
            LstExpediente.Items.Add("347759038");
            LstExpediente.Items[2].SubItems.Add("Pedro Ramos Llano");

            //Se llena la listview de Usuarios
            LstUsuarios.Items.Add("CFERNANDEZ", 0);
            LstUsuarios.Items[0].SubItems.Add("Carlos Fernadez Garcia");
            LstUsuarios.Items.Add("GMESEN", 0);
            LstUsuarios.Items[1].SubItems.Add("Georgi Mesen Cerdas");

            //Se llena la listview de Citas
            LstCitas.Items.Add("Carlos Fernadez Garcia");
            LstCitas.Items[0].SubItems.Add("13/05/2018");
            LstCitas.Items[0].SubItems.Add("10:00 am");
            LstCitas.Items.Add("Marco Perez Gomez");
            LstCitas.Items[1].SubItems.Add("29/01/2018");
            LstCitas.Items[1].SubItems.Add("3:00 pm");
            LstCitas.Items.Add("Pedro Ramos Llano");
            LstCitas.Items[2].SubItems.Add("25/08/2018");
            LstCitas.Items[2].SubItems.Add("8:00 am");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
        }


        private void LstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pacientes pa = new Pacientes();
            pa.ShowDialog();
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

        private void LstMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicamentos me = new Medicamentos();
            me.ShowDialog();
        }

        private void LstExpediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Expediente ex = new Expediente();
            ex.ShowDialog();
        }

        private void LstActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actividades ac = new Actividades();
            ac.ShowDialog();
        }

        private void LstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog(); 
        }

        private void LstCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cita ci = new Cita();
            ci.ShowDialog(); 
        }
    }
}
