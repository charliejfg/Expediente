namespace ProyectoHogarAncianos
{
    partial class Recetas
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFecha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFrecuencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboMedicamento = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaciente = new MaterialSkin.Controls.MaterialLabel();
            this.cboVia = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.idMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(369, 89);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Paciente:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(283, 192);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(31, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Via";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(474, 192);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Frecuencia";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(28, 192);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Medicamento:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(34, 89);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(53, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Depth = 0;
            this.txtFecha.Hint = "";
            this.txtFecha.Location = new System.Drawing.Point(151, 85);
            this.txtFecha.MaxLength = 32767;
            this.txtFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.PasswordChar = '\0';
            this.txtFecha.SelectedText = "";
            this.txtFecha.SelectionLength = 0;
            this.txtFecha.SelectionStart = 0;
            this.txtFecha.Size = new System.Drawing.Size(163, 23);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.TabStop = false;
            this.txtFecha.UseSystemPasswordChar = false;
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Depth = 0;
            this.txtFrecuencia.Hint = "";
            this.txtFrecuencia.Location = new System.Drawing.Point(574, 188);
            this.txtFrecuencia.MaxLength = 32767;
            this.txtFrecuencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.PasswordChar = '\0';
            this.txtFrecuencia.SelectedText = "";
            this.txtFrecuencia.SelectionLength = 0;
            this.txtFrecuencia.SelectionStart = 0;
            this.txtFrecuencia.Size = new System.Drawing.Size(176, 23);
            this.txtFrecuencia.TabIndex = 10;
            this.txtFrecuencia.TabStop = false;
            this.txtFrecuencia.UseSystemPasswordChar = false;
            // 
            // cboMedicamento
            // 
            this.cboMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedicamento.FormattingEnabled = true;
            this.cboMedicamento.Location = new System.Drawing.Point(133, 193);
            this.cboMedicamento.Name = "cboMedicamento";
            this.cboMedicamento.Size = new System.Drawing.Size(121, 21);
            this.cboMedicamento.TabIndex = 12;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(431, 458);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 36);
            this.materialRaisedButton1.TabIndex = 15;
            this.materialRaisedButton1.Text = "Guardar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(223, 458);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 14;
            this.materialFlatButton1.Text = "Cancelar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(HjaContext.Persona);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Depth = 0;
            this.lblPaciente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPaciente.Location = new System.Drawing.Point(485, 89);
            this.lblPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(0, 19);
            this.lblPaciente.TabIndex = 16;
            // 
            // cboVia
            // 
            this.cboVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVia.FormattingEnabled = true;
            this.cboVia.Location = new System.Drawing.Point(321, 193);
            this.cboVia.Name = "cboVia";
            this.cboVia.Size = new System.Drawing.Size(121, 21);
            this.cboVia.TabIndex = 17;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 154);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(133, 150);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(121, 23);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamento,
            this.CodigoMedicamento,
            this.NombreMedicamento,
            this.idVia,
            this.Via,
            this.Frecuencia});
            this.dgvDetalle.Location = new System.Drawing.Point(38, 281);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(718, 150);
            this.dgvDetalle.TabIndex = 20;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(32, 236);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(83, 36);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(133, 236);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // idMedicamento
            // 
            this.idMedicamento.HeaderText = "id";
            this.idMedicamento.Name = "idMedicamento";
            // 
            // CodigoMedicamento
            // 
            this.CodigoMedicamento.DataPropertyName = "descripcion";
            this.CodigoMedicamento.HeaderText = "Codigo";
            this.CodigoMedicamento.Name = "CodigoMedicamento";
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.HeaderText = "Nombre";
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.Width = 250;
            // 
            // idVia
            // 
            this.idVia.HeaderText = "idVia";
            this.idVia.Name = "idVia";
            // 
            // Via
            // 
            this.Via.HeaderText = "Via";
            this.Via.Name = "Via";
            this.Via.Width = 200;
            // 
            // Frecuencia
            // 
            this.Frecuencia.HeaderText = "Frecuencia";
            this.Frecuencia.Name = "Frecuencia";
            this.Frecuencia.Width = 120;
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 529);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cboVia);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cboMedicamento);
            this.Controls.Add(this.txtFrecuencia);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Name = "Recetas";
            this.Text = "Recetas";
            this.Load += new System.EventHandler(this.Recetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFrecuencia;
        private System.Windows.Forms.ComboBox cboMedicamento;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private MaterialSkin.Controls.MaterialLabel lblPaciente;
        private System.Windows.Forms.ComboBox cboVia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Via;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia;
    }
}