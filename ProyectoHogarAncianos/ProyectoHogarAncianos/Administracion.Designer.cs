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
            this.LstUsuarios = new System.Windows.Forms.ListView();
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabCitas = new System.Windows.Forms.TabPage();
            this.LstCitas = new MaterialSkin.Controls.MaterialListView();
            this.PacienteCita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaCita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabExpediente = new System.Windows.Forms.TabPage();
            this.LstExpediente = new MaterialSkin.Controls.MaterialListView();
            this.Expediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpPaciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabRecetas = new System.Windows.Forms.TabPage();
            this.LstRecetas = new MaterialSkin.Controls.MaterialListView();
            this.numReceta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacienteReceta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabMedicamentos = new System.Windows.Forms.TabPage();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.LstMedicamentos = new MaterialSkin.Controls.MaterialListView();
            this.NombreMedicamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoMedicamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabActividades = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.LstActividades = new MaterialSkin.Controls.MaterialListView();
            this.Actividad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPacientes = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.LstPacientes = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumExpediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            this.tabCitas.SuspendLayout();
            this.tabExpediente.SuspendLayout();
            this.tabRecetas.SuspendLayout();
            this.tabMedicamentos.SuspendLayout();
            this.tabActividades.SuspendLayout();
            this.tabPacientes.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(793, 294);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.LstUsuarios);
            this.tabUsuarios.Controls.Add(this.materialFlatButton7);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(785, 268);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // LstUsuarios
            // 
            this.LstUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Usuario,
            this.NomUsuario});
            this.LstUsuarios.FullRowSelect = true;
            this.LstUsuarios.Location = new System.Drawing.Point(115, 74);
            this.LstUsuarios.Name = "LstUsuarios";
            this.LstUsuarios.Size = new System.Drawing.Size(447, 109);
            this.LstUsuarios.SmallImageList = this.imageList1;
            this.LstUsuarios.TabIndex = 2;
            this.LstUsuarios.UseCompatibleStateImageBehavior = false;
            this.LstUsuarios.View = System.Windows.Forms.View.Details;
            this.LstUsuarios.SelectedIndexChanged += new System.EventHandler(this.LstUsuarios_SelectedIndexChanged);
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            this.Usuario.Width = 142;
            // 
            // NomUsuario
            // 
            this.NomUsuario.Text = "Nombre";
            this.NomUsuario.Width = 257;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "usuario.bmp");
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(273, 18);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(126, 36);
            this.materialFlatButton7.TabIndex = 1;
            this.materialFlatButton7.Text = "Nuevo Usuario";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // tabCitas
            // 
            this.tabCitas.Controls.Add(this.LstCitas);
            this.tabCitas.Controls.Add(this.materialFlatButton6);
            this.tabCitas.Location = new System.Drawing.Point(4, 22);
            this.tabCitas.Name = "tabCitas";
            this.tabCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCitas.Size = new System.Drawing.Size(785, 268);
            this.tabCitas.TabIndex = 1;
            this.tabCitas.Text = "Citas";
            this.tabCitas.UseVisualStyleBackColor = true;
            // 
            // LstCitas
            // 
            this.LstCitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstCitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PacienteCita,
            this.FechaCita,
            this.Hora});
            this.LstCitas.Depth = 0;
            this.LstCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LstCitas.FullRowSelect = true;
            this.LstCitas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstCitas.Location = new System.Drawing.Point(131, 66);
            this.LstCitas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LstCitas.MouseState = MaterialSkin.MouseState.OUT;
            this.LstCitas.Name = "LstCitas";
            this.LstCitas.OwnerDraw = true;
            this.LstCitas.Size = new System.Drawing.Size(625, 122);
            this.LstCitas.TabIndex = 2;
            this.LstCitas.UseCompatibleStateImageBehavior = false;
            this.LstCitas.View = System.Windows.Forms.View.Details;
            this.LstCitas.SelectedIndexChanged += new System.EventHandler(this.LstCitas_SelectedIndexChanged);
            // 
            // PacienteCita
            // 
            this.PacienteCita.Text = "Paciente";
            this.PacienteCita.Width = 212;
            // 
            // FechaCita
            // 
            this.FechaCita.Text = "Fecha";
            this.FechaCita.Width = 173;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            this.Hora.Width = 141;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(288, 9);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(99, 36);
            this.materialFlatButton6.TabIndex = 1;
            this.materialFlatButton6.Text = "Nueva Cita";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // tabExpediente
            // 
            this.tabExpediente.Controls.Add(this.LstExpediente);
            this.tabExpediente.Controls.Add(this.materialFlatButton5);
            this.tabExpediente.Location = new System.Drawing.Point(4, 22);
            this.tabExpediente.Name = "tabExpediente";
            this.tabExpediente.Size = new System.Drawing.Size(785, 268);
            this.tabExpediente.TabIndex = 2;
            this.tabExpediente.Text = "Expedientes";
            this.tabExpediente.UseVisualStyleBackColor = true;
            // 
            // LstExpediente
            // 
            this.LstExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstExpediente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Expediente,
            this.ExpPaciente});
            this.LstExpediente.Depth = 0;
            this.LstExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LstExpediente.FullRowSelect = true;
            this.LstExpediente.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstExpediente.Location = new System.Drawing.Point(30, 60);
            this.LstExpediente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LstExpediente.MouseState = MaterialSkin.MouseState.OUT;
            this.LstExpediente.Name = "LstExpediente";
            this.LstExpediente.OwnerDraw = true;
            this.LstExpediente.Size = new System.Drawing.Size(725, 126);
            this.LstExpediente.TabIndex = 1;
            this.LstExpediente.UseCompatibleStateImageBehavior = false;
            this.LstExpediente.View = System.Windows.Forms.View.Details;
            this.LstExpediente.SelectedIndexChanged += new System.EventHandler(this.LstExpediente_SelectedIndexChanged);
            // 
            // Expediente
            // 
            this.Expediente.Text = "Numero de Expediente";
            this.Expediente.Width = 345;
            // 
            // ExpPaciente
            // 
            this.ExpPaciente.Text = "Paciente";
            this.ExpPaciente.Width = 254;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(276, 15);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(149, 36);
            this.materialFlatButton5.TabIndex = 0;
            this.materialFlatButton5.Text = "Nuevo Expediente";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // tabRecetas
            // 
            this.tabRecetas.Controls.Add(this.LstRecetas);
            this.tabRecetas.Controls.Add(this.materialFlatButton4);
            this.tabRecetas.Location = new System.Drawing.Point(4, 22);
            this.tabRecetas.Name = "tabRecetas";
            this.tabRecetas.Size = new System.Drawing.Size(785, 268);
            this.tabRecetas.TabIndex = 3;
            this.tabRecetas.Text = "Recetas";
            this.tabRecetas.UseVisualStyleBackColor = true;
            // 
            // LstRecetas
            // 
            this.LstRecetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstRecetas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numReceta,
            this.PacienteReceta});
            this.LstRecetas.Depth = 0;
            this.LstRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LstRecetas.FullRowSelect = true;
            this.LstRecetas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstRecetas.Location = new System.Drawing.Point(49, 68);
            this.LstRecetas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LstRecetas.MouseState = MaterialSkin.MouseState.OUT;
            this.LstRecetas.Name = "LstRecetas";
            this.LstRecetas.OwnerDraw = true;
            this.LstRecetas.Size = new System.Drawing.Size(689, 119);
            this.LstRecetas.TabIndex = 1;
            this.LstRecetas.UseCompatibleStateImageBehavior = false;
            this.LstRecetas.View = System.Windows.Forms.View.Details;
            this.LstRecetas.SelectedIndexChanged += new System.EventHandler(this.LstRecetas_SelectedIndexChanged);
            // 
            // numReceta
            // 
            this.numReceta.Text = "Numero de Receta";
            this.numReceta.Width = 300;
            // 
            // PacienteReceta
            // 
            this.PacienteReceta.Text = "Paciente de receta";
            this.PacienteReceta.Width = 340;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(311, 23);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(119, 36);
            this.materialFlatButton4.TabIndex = 0;
            this.materialFlatButton4.Text = "Nueva Receta";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // tabMedicamentos
            // 
            this.tabMedicamentos.Controls.Add(this.materialFlatButton3);
            this.tabMedicamentos.Controls.Add(this.LstMedicamentos);
            this.tabMedicamentos.Location = new System.Drawing.Point(4, 22);
            this.tabMedicamentos.Name = "tabMedicamentos";
            this.tabMedicamentos.Size = new System.Drawing.Size(785, 268);
            this.tabMedicamentos.TabIndex = 4;
            this.tabMedicamentos.Text = "Medicamentos";
            this.tabMedicamentos.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(284, 23);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(167, 36);
            this.materialFlatButton3.TabIndex = 1;
            this.materialFlatButton3.Text = "Nuevo Medicamento";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // LstMedicamentos
            // 
            this.LstMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstMedicamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreMedicamento,
            this.TipoMedicamento});
            this.LstMedicamentos.Depth = 0;
            this.LstMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LstMedicamentos.FullRowSelect = true;
            this.LstMedicamentos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstMedicamentos.Location = new System.Drawing.Point(58, 68);
            this.LstMedicamentos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LstMedicamentos.MouseState = MaterialSkin.MouseState.OUT;
            this.LstMedicamentos.Name = "LstMedicamentos";
            this.LstMedicamentos.OwnerDraw = true;
            this.LstMedicamentos.Size = new System.Drawing.Size(689, 139);
            this.LstMedicamentos.TabIndex = 0;
            this.LstMedicamentos.UseCompatibleStateImageBehavior = false;
            this.LstMedicamentos.View = System.Windows.Forms.View.Details;
            this.LstMedicamentos.SelectedIndexChanged += new System.EventHandler(this.LstMedicamentos_SelectedIndexChanged);
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.Text = "Nombre";
            this.NombreMedicamento.Width = 274;
            // 
            // TipoMedicamento
            // 
            this.TipoMedicamento.Text = "Tipo";
            this.TipoMedicamento.Width = 202;
            // 
            // tabActividades
            // 
            this.tabActividades.Controls.Add(this.materialFlatButton2);
            this.tabActividades.Controls.Add(this.LstActividades);
            this.tabActividades.Location = new System.Drawing.Point(4, 22);
            this.tabActividades.Name = "tabActividades";
            this.tabActividades.Size = new System.Drawing.Size(785, 268);
            this.tabActividades.TabIndex = 5;
            this.tabActividades.Text = "Actividades";
            this.tabActividades.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(320, 23);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(139, 36);
            this.materialFlatButton2.TabIndex = 5;
            this.materialFlatButton2.Text = "Nueva Actividad";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // LstActividades
            // 
            this.LstActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstActividades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Actividad});
            this.LstActividades.Depth = 0;
            this.LstActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.LstActividades.FullRowSelect = true;
            this.LstActividades.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstActividades.Location = new System.Drawing.Point(152, 84);
            this.LstActividades.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LstActividades.MouseState = MaterialSkin.MouseState.OUT;
            this.LstActividades.Name = "LstActividades";
            this.LstActividades.OwnerDraw = true;
            this.LstActividades.Size = new System.Drawing.Size(540, 113);
            this.LstActividades.TabIndex = 0;
            this.LstActividades.UseCompatibleStateImageBehavior = false;
            this.LstActividades.View = System.Windows.Forms.View.Details;
            this.LstActividades.SelectedIndexChanged += new System.EventHandler(this.LstActividades_SelectedIndexChanged);
            // 
            // Actividad
            // 
            this.Actividad.Text = "Actividad";
            this.Actividad.Width = 446;
            // 
            // tabPacientes
            // 
            this.tabPacientes.Controls.Add(this.materialFlatButton1);
            this.tabPacientes.Controls.Add(this.LstPacientes);
            this.tabPacientes.Location = new System.Drawing.Point(4, 22);
            this.tabPacientes.Name = "tabPacientes";
            this.tabPacientes.Size = new System.Drawing.Size(785, 268);
            this.tabPacientes.TabIndex = 6;
            this.tabPacientes.Text = "Pacientes";
            this.tabPacientes.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(297, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(134, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Nuevo Paciente";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // LstPacientes
            // 
            this.LstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Genero,
            this.NumExpediente});
            this.LstPacientes.FullRowSelect = true;
            this.LstPacientes.Location = new System.Drawing.Point(70, 51);
            this.LstPacientes.Name = "LstPacientes";
            this.LstPacientes.Size = new System.Drawing.Size(661, 160);
            this.LstPacientes.SmallImageList = this.imageList1;
            this.LstPacientes.TabIndex = 2;
            this.LstPacientes.UseCompatibleStateImageBehavior = false;
            this.LstPacientes.View = System.Windows.Forms.View.Details;
            this.LstPacientes.SelectedIndexChanged += new System.EventHandler(this.LstPacientes_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 279;
            // 
            // Genero
            // 
            this.Genero.Text = "Género";
            this.Genero.Width = 119;
            // 
            // NumExpediente
            // 
            this.NumExpediente.Text = "Número de expediente";
            this.NumExpediente.Width = 127;
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
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Administracion";
            this.Text = "Administración - Mantenimientos";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            this.tabCitas.ResumeLayout(false);
            this.tabCitas.PerformLayout();
            this.tabExpediente.ResumeLayout(false);
            this.tabExpediente.PerformLayout();
            this.tabRecetas.ResumeLayout(false);
            this.tabRecetas.PerformLayout();
            this.tabMedicamentos.ResumeLayout(false);
            this.tabMedicamentos.PerformLayout();
            this.tabActividades.ResumeLayout(false);
            this.tabActividades.PerformLayout();
            this.tabPacientes.ResumeLayout(false);
            this.tabPacientes.PerformLayout();
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView LstPacientes;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Genero;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ColumnHeader NumExpediente;
        private MaterialSkin.Controls.MaterialListView LstActividades;
        private System.Windows.Forms.ColumnHeader Actividad;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialListView LstMedicamentos;
        private System.Windows.Forms.ColumnHeader NombreMedicamento;
        private System.Windows.Forms.ColumnHeader TipoMedicamento;
        private MaterialSkin.Controls.MaterialListView LstRecetas;
        private System.Windows.Forms.ColumnHeader numReceta;
        private System.Windows.Forms.ColumnHeader PacienteReceta;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialListView LstExpediente;
        private System.Windows.Forms.ColumnHeader Expediente;
        private System.Windows.Forms.ColumnHeader ExpPaciente;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialListView LstCitas;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private System.Windows.Forms.ColumnHeader PacienteCita;
        private System.Windows.Forms.ColumnHeader FechaCita;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ListView LstUsuarios;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader NomUsuario;
    }
}