using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoHogarAncianosLogica;

namespace ProyectoHogarAncianos
{
    public partial class Encryptado : Form
    {
        public Encryptado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaLogica nuevaLogica = new PersonaLogica();
            txtEncrypt.Text = nuevaLogica.getClaveEncriptada(txtClave.Text);
        }
    }
}
