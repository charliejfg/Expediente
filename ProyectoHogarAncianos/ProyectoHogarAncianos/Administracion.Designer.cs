namespace ProyectoHogarAncianos
{
    partial class Administracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tabCitas = new System.Windows.Forms.TabPage();
            this.tabExpediente = new System.Windows.Forms.TabPage();
            this.tabRecetas = new System.Windows.Forms.TabPage();
            this.tabMedicamentos = new System.Windows.Forms.TabPage();
            this.tabActividades = new System.Windows.Forms.TabPage();
            this.tabPacientes = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.tabActividades.SuspendLayout();
            this.tabPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(830, 35);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabUsuarios);
            this.materialTabControl1.Controls.Add(this.tabCitas);
            this.materialTabControl1.Controls.Add(this.tabExpediente);
            this.materialTabControl1.Controls.Add(this.tabRecetas);
            this.materialTabControl1.Controls.Add(this.tabMedicamentos);
            this.materialTabControl1.Controls.Add(this.tabActividades);
            this.materialTabControl1.Controls.Add(this.tabPacientes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 104);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(793, 249);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(785, 223);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabCitas
            // 
            this.tabCitas.Location = new System.Drawing.Point(4, 22);
            this.tabCitas.Name = "tabCitas";
            this.tabCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCitas.Size = new System.Drawing.Size(785, 223);
            this.tabCitas.TabIndex = 1;
            this.tabCitas.Text = "Citas";
            this.tabCitas.UseVisualStyleBackColor = true;
            // 
            // tabExpediente
            // 
            this.tabExpediente.Location = new System.Drawing.Point(4, 22);
            this.tabExpediente.Name = "tabExpediente";
            this.tabExpediente.Size = new System.Drawing.Size(785, 223);
            this.tabExpediente.TabIndex = 2;
            this.tabExpediente.Text = "Expedientes";
            this.tabExpediente.UseVisualStyleBackColor = true;
            // 
            // tabRecetas
            // 
            this.tabRecetas.Location = new System.Drawing.Point(4, 22);
            this.tabRecetas.Name = "tabRecetas";
            this.tabRecetas.Size = new System.Drawing.Size(785, 223);
            this.tabRecetas.TabIndex = 3;
            this.tabRecetas.Text = "Recetas";
            this.tabRecetas.UseVisualStyleBackColor = true;
            // 
            // tabMedicamentos
            // 
            this.tabMedicamentos.Location = new System.Drawing.Point(4, 22);
            this.tabMedicamentos.Name = "tabMedicamentos";
            this.tabMedicamentos.Size = new System.Drawing.Size(785, 223);
            this.tabMedicamentos.TabIndex = 4;
            this.tabMedicamentos.Text = "Medicamentos";
            this.tabMedicamentos.UseVisualStyleBackColor = true;
            // 
            // tabActividades
            // 
            this.tabActividades.Controls.Add(this.dataGridView1);
            this.tabActividades.Location = new System.Drawing.Point(4, 22);
            this.tabActividades.Name = "tabActividades";
            this.tabActividades.Size = new System.Drawing.Size(785, 223);
            this.tabActividades.TabIndex = 5;
            this.tabActividades.Text = "Actividades";
            this.tabActividades.UseVisualStyleBackColor = true;
            // 
            // tabPacientes
            // 
            this.tabPacientes.Controls.Add(this.listView1);
            this.tabPacientes.Location = new System.Drawing.Point(4, 22);
            this.tabPacientes.Name = "tabPacientes";
            this.tabPacientes.Size = new System.Drawing.Size(785, 223);
            this.tabPacientes.TabIndex = 6;
            this.tabPacientes.Text = "Pacientes";
            this.tabPacientes.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Sexo});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(72, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 160);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 279;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "usuario.bmp");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoHogarAncianos.Properties.Resources.Action___States___Vol__3_19_512;
            this.pictureBox1.Location = new System.Drawing.Point(16, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePaciente});
            this.dataGridView1.Location = new System.Drawing.Point(95, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.HeaderText = "Nombre Paciente";
            this.NombrePaciente.Name = "NombrePaciente";
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.Width = 119;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Administracion";
            this.Text = "Administración - Mantemientos";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabActividades.ResumeLayout(false);
            this.tabPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.TabPage tabCitas;
        private System.Windows.Forms.TabPage tabExpediente;
        private System.Windows.Forms.TabPage tabRecetas;
        private System.Windows.Forms.TabPage tabMedicamentos;
        private System.Windows.Forms.TabPage tabActividades;
        private System.Windows.Forms.TabPage tabPacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.ColumnHeader Sexo;
    }
}