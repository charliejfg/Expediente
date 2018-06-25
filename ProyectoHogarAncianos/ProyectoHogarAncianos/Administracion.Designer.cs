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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.tabCitas = new System.Windows.Forms.TabPage();
            this.tabExpediente = new System.Windows.Forms.TabPage();
            this.tabRecetas = new System.Windows.Forms.TabPage();
            this.tabMedicamentos = new System.Windows.Forms.TabPage();
            this.tabActividades = new System.Windows.Forms.TabPage();
            this.tabPacientes = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabActividades.Location = new System.Drawing.Point(4, 22);
            this.tabActividades.Name = "tabActividades";
            this.tabActividades.Size = new System.Drawing.Size(785, 223);
            this.tabActividades.TabIndex = 5;
            this.tabActividades.Text = "Actividades";
            this.tabActividades.UseVisualStyleBackColor = true;
            // 
            // tabPacientes
            // 
            this.tabPacientes.Location = new System.Drawing.Point(4, 22);
            this.tabPacientes.Name = "tabPacientes";
            this.tabPacientes.Size = new System.Drawing.Size(785, 223);
            this.tabPacientes.TabIndex = 6;
            this.tabPacientes.Text = "Pacientes";
            this.tabPacientes.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}