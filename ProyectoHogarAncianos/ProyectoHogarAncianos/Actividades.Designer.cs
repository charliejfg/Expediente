namespace ProyectoHogarAncianos
{
    partial class Actividades
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtActividad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txaDescripcion = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Actividad";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Descripcion";
            // 
            // txtActividad
            // 
            this.txtActividad.Depth = 0;
            this.txtActividad.Hint = "";
            this.txtActividad.Location = new System.Drawing.Point(110, 84);
            this.txtActividad.MaxLength = 32767;
            this.txtActividad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.PasswordChar = '\0';
            this.txtActividad.SelectedText = "";
            this.txtActividad.SelectionLength = 0;
            this.txtActividad.SelectionStart = 0;
            this.txtActividad.Size = new System.Drawing.Size(264, 23);
            this.txtActividad.TabIndex = 2;
            this.txtActividad.TabStop = false;
            this.txtActividad.UseSystemPasswordChar = false;
            // 
            // txaDescripcion
            // 
            this.txaDescripcion.Location = new System.Drawing.Point(110, 165);
            this.txaDescripcion.Multiline = true;
            this.txaDescripcion.Name = "txaDescripcion";
            this.txaDescripcion.Size = new System.Drawing.Size(264, 121);
            this.txaDescripcion.TabIndex = 3;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(70, 321);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "Cancelar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(187, 321);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(84, 36);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "Guardar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 370);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txaDescripcion);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtActividad;
        private System.Windows.Forms.TextBox txaDescripcion;
    }
}