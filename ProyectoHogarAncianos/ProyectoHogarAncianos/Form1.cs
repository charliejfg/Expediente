using HjaContext;
using Npgsql;
using NpgsqlTypes;
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
    public partial class Form1 : Form
    {
        //string parametros = "User Id=hja;Password=hja;Host=localhost;Port=5432;Database=hja;Persist Security Info=True;Initial Schema=hja";
        string parametros = "Server=localhost;Port=5432;User Id=hja;Password=123456;Database=hja;";
        string query = "";
        string nombre = "";
        string dato1 = string.Empty;
        string dato2 = string.Empty;
        int id = 0;
        int nota = 0;

        DataSet datos = new DataSet();
        NpgsqlConnection conn = new NpgsqlConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = parametros;

            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR" + error);
            }
            query = "select * from hja.actividades;";
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(query,conn);
            add.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            conn.Close();
            DataTable dt = datos.Tables[0];
            List<Actividade> cli = (from DataRow row in dt.Rows
            select new Actividade()
            {
                Id = Convert.ToInt32(row["ID"].ToString()),
                Descripcion = row["descripcion"].ToString(),
                Actividad = row["actividad"].ToString()
            }).ToList();
            List<Actividade> cli1 = cli; 
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }
    }
}
