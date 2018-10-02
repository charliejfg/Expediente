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
using ProyectoHogarAncianosLogica;
using HjaContext;

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
            PacienteLogica PacienteLogica = new PacienteLogica();
            List<Paciente> ListaPaciente = new List<Paciente>();
            ListaPaciente = PacienteLogica.TraerPaciente();
            int p = 0;
            foreach (Paciente PacienteLista in ListaPaciente)
            {
                LstPacientes.Items.Add(Convert.ToString(PacienteLista.Id));
                LstPacientes.Items[p].SubItems.Add(PacienteLista.Cedula);
                LstPacientes.Items[p].SubItems.Add(PacienteLista.Nombre);
                LstPacientes.Items[p].SubItems.Add(PacienteLista.Apellido1);
                LstPacientes.Items[p].SubItems.Add(PacienteLista.Apellido2);
                p++;
            }
            //Se llena la listview de pacientes
            //LstPacientes.Items.Add("Carlos Fernadez Garcia", 0);
            //LstPacientes.Items[0].SubItems.Add("Hombre");
            //LstPacientes.Items[0].SubItems.Add("1");
            //LstPacientes.Items.Add("Georgi Mesen Cerdas", 0);
            //LstPacientes.Items[1].SubItems.Add("Hombre");
            //LstPacientes.Items[1].SubItems.Add("2");
            //LstPacientes.Items.Add("Pedro Ramos Llano", 0);
            //LstPacientes.Items[2].SubItems.Add("Hombre");
            //LstPacientes.Items[2].SubItems.Add("3");
            //LstPacientes.Items.Add("Andres Cordero Ruiz", 0);
            //LstPacientes.Items[3].SubItems.Add("Hombre");
            //LstPacientes.Items[3].SubItems.Add("4");
            //LstPacientes.Items.Add("Marco Perez Gomez", 0);
            //LstPacientes.Items[4].SubItems.Add("Hombre");
            //LstPacientes.Items[4].SubItems.Add("5");

            //Se llena la listview de actividades
            ActividadLogica actividadLogica = new ActividadLogica();
            List<Actividade> ListaActividad = new List<Actividade>();
            ListaActividad = actividadLogica.TraerActividad();
            int i = 0;
            foreach (Actividade actividadLista in ListaActividad)
            {
                LstActividades.Items.Add(Convert.ToString(actividadLista.Id));
                LstActividades.Items[i].SubItems.Add(actividadLista.Actividad);
                i++;
            }

            //Se llena la listview de medicamentos
            MedicamentoLogica medicamentoLogica = new MedicamentoLogica();
            List<Medicamento> ListaMedicamento = new List<Medicamento>();
            ListaMedicamento = medicamentoLogica.TraerMedicamentos();
            int m = 0;
            foreach (Medicamento medicamentoLista in ListaMedicamento)
            {
                LstMedicamentos.Items.Add(Convert.ToString(medicamentoLista.Id));
                LstMedicamentos.Items[m].SubItems.Add(medicamentoLista.Codigo);
                LstMedicamentos.Items[m].SubItems.Add(medicamentoLista.Descripcion);
                m++;
            }

            //LstMedicamentos.Items.Add("Morfina");
            //LstMedicamentos.Items[0].SubItems.Add("Anestésicos");
            //LstMedicamentos.Items.Add("Paracetamol");
            //LstMedicamentos.Items[1].SubItems.Add("Antiinflamatorios");
            //LstMedicamentos.Items.Add("Fenobarbital");
            //LstMedicamentos.Items[2].SubItems.Add("Anticonvulsivo");

            //Se llena la listview de medicamentos
            RecetaLogica recetaLogica = new RecetaLogica();
            PacienteLogica pacienteLogica = new PacienteLogica();
            List<Receta> ListaReceta = new List<Receta>();
            ListaReceta = recetaLogica.TraerReceta();
            int r = 0;
            foreach (Receta recetaLista in ListaReceta)
            {
                LstRecetas.Items.Add(Convert.ToString(recetaLista.Id));
                LstRecetas.Items[r].SubItems.Add(pacienteLogica.TraerPacientePorId(recetaLista.PamId).Nombre);
                r++;
            }
            //LstRecetas.Items.Add("1");
            //LstRecetas.Items[0].SubItems.Add("Andres Cordero Ruiz");
            //LstRecetas.Items.Add("2");
            //LstRecetas.Items[1].SubItems.Add("Marco Perez Gomez");
            //LstRecetas.Items.Add("3");
            //LstRecetas.Items[2].SubItems.Add("Pedro Ramos Llano");

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
            ac.idActividad=Convert.ToInt32(LstActividades.SelectedItems[0].Text);
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

        private void LstRecetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recetas re = new Recetas();
            re.ShowDialog();
        }

        private void txtBuscarActividad_TextChanged(object sender, EventArgs e)
        {
            LstActividades.Items.Clear();
            ActividadLogica actividadLogica = new ActividadLogica();
            List<Actividade> ListaActividad = new List<Actividade>();
            ListaActividad = actividadLogica.BuscarActividad(txtBuscarActividad.Text);
            int i = 0;
            foreach (Actividade actividadLista in ListaActividad)
            {
                LstActividades.Items.Add(Convert.ToString(actividadLista.Id));
                LstActividades.Items[i].SubItems.Add(actividadLista.Actividad);
                i++;
            }
        }

        private void btnNuevaActividad_Click(object sender, EventArgs e)
        {
            Actividades ac = new Actividades();
            ac.ShowDialog();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Pacientes ac = new Pacientes();
            ac.ShowDialog();
        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarMedicamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoMedicamento_Click(object sender, EventArgs e)
        {
            Medicamentos me = new Medicamentos();
            me.ShowDialog();
        }
    }
}
