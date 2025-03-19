namespace HitoriaClinica
{
    partial class UcPacientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPacientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            IlGaleria = new ImageList(components);
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            cbSexo = new ComboBox();
            tbCedula = new TextBox();
            PbSiguiente = new PictureBox();
            PanelFromulario1 = new Panel();
            TbAlch = new TextBox();
            TbFisica = new TextBox();
            TbTabaquis = new TextBox();
            TbOcupa = new TextBox();
            TbOtros = new TextBox();
            CbTaba = new CheckBox();
            CbAlcho = new CheckBox();
            CbFisica = new CheckBox();
            CbOtro = new CheckBox();
            label5 = new Label();
            tbExpliBio = new TextBox();
            CbBiopoli = new CheckBox();
            TbExpliTrata = new TextBox();
            CbTrata = new CheckBox();
            TbExpliCiru = new TextBox();
            CbCiru = new CheckBox();
            TbExpliAlergAli = new TextBox();
            CbAlergiAli = new CheckBox();
            TbExplAlergiaMed = new TextBox();
            CbAlegiaMedi = new CheckBox();
            tbExpliEnfer = new TextBox();
            CbEnfermedad = new CheckBox();
            label4 = new Label();
            TbApellido = new TextBox();
            TbTele = new TextBox();
            DtNacimiendo = new DateTimePicker();
            tbEdad = new TextBox();
            label3 = new Label();
            PanelFromulario2 = new Panel();
            DtTratamiento = new DateTimePicker();
            LbPaciente = new Label();
            RbGuardar = new PictureBox();
            PbBorrar = new PictureBox();
            BbAtras = new PictureBox();
            label8 = new Label();
            PbAgregar = new PictureBox();
            label7 = new Label();
            RtDescriTrata = new RichTextBox();
            label6 = new Label();
            CbTratamientos = new ComboBox();
            RtHistoTratamiento = new RichTextBox();
            label2 = new Label();
            RtExamenFisico = new RichTextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            PanelFromulario3 = new Panel();
            TbBuscar = new TextBox();
            GvConsulta = new DataGridView();
            BtnImprimir = new DataGridViewButtonColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            PbGaleria = new PictureBox();
            PbRostro = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PbSiguiente).BeginInit();
            PanelFromulario1.SuspendLayout();
            PanelFromulario2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbBorrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BbAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelFromulario3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbGaleria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbRostro).BeginInit();
            SuspendLayout();
            // 
            // IlGaleria
            // 
            IlGaleria.ColorDepth = ColorDepth.Depth32Bit;
            IlGaleria.ImageSize = new Size(170, 220);
            IlGaleria.TransparentColor = Color.RosyBrown;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.ControlLight;
            tbNombre.Cursor = Cursors.IBeam;
            tbNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(22, 45);
            tbNombre.Margin = new Padding(5);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombres";
            tbNombre.Size = new Size(310, 26);
            tbNombre.TabIndex = 1;
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = SystemColors.ControlLight;
            tbDireccion.Cursor = Cursors.IBeam;
            tbDireccion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDireccion.Location = new Point(22, 113);
            tbDireccion.Margin = new Padding(5);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.PlaceholderText = "Dirección";
            tbDireccion.Size = new Size(853, 46);
            tbDireccion.TabIndex = 8;
            // 
            // cbSexo
            // 
            cbSexo.BackColor = SystemColors.ControlLight;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "< Sexo >", "Masculino", "Femenino" });
            cbSexo.Location = new Point(669, 79);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(206, 26);
            cbSexo.TabIndex = 7;
            // 
            // tbCedula
            // 
            tbCedula.BackColor = SystemColors.ControlLight;
            tbCedula.Cursor = Cursors.IBeam;
            tbCedula.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCedula.Location = new Point(669, 45);
            tbCedula.Margin = new Padding(5);
            tbCedula.Name = "tbCedula";
            tbCedula.PlaceholderText = "Cédula";
            tbCedula.Size = new Size(206, 26);
            tbCedula.TabIndex = 3;
            // 
            // PbSiguiente
            // 
            PbSiguiente.Cursor = Cursors.Hand;
            PbSiguiente.Image = (Image)resources.GetObject("PbSiguiente.Image");
            PbSiguiente.Location = new Point(786, 629);
            PbSiguiente.Name = "PbSiguiente";
            PbSiguiente.Size = new Size(85, 80);
            PbSiguiente.SizeMode = PictureBoxSizeMode.StretchImage;
            PbSiguiente.TabIndex = 1009;
            PbSiguiente.TabStop = false;
            PbSiguiente.Click += PbSiguiente_Click;
            // 
            // PanelFromulario1
            // 
            PanelFromulario1.BackColor = Color.Transparent;
            PanelFromulario1.Controls.Add(TbAlch);
            PanelFromulario1.Controls.Add(TbFisica);
            PanelFromulario1.Controls.Add(TbTabaquis);
            PanelFromulario1.Controls.Add(TbOcupa);
            PanelFromulario1.Controls.Add(TbOtros);
            PanelFromulario1.Controls.Add(CbTaba);
            PanelFromulario1.Controls.Add(CbAlcho);
            PanelFromulario1.Controls.Add(CbFisica);
            PanelFromulario1.Controls.Add(CbOtro);
            PanelFromulario1.Controls.Add(label5);
            PanelFromulario1.Controls.Add(tbExpliBio);
            PanelFromulario1.Controls.Add(CbBiopoli);
            PanelFromulario1.Controls.Add(TbExpliTrata);
            PanelFromulario1.Controls.Add(CbTrata);
            PanelFromulario1.Controls.Add(TbExpliCiru);
            PanelFromulario1.Controls.Add(CbCiru);
            PanelFromulario1.Controls.Add(TbExpliAlergAli);
            PanelFromulario1.Controls.Add(CbAlergiAli);
            PanelFromulario1.Controls.Add(TbExplAlergiaMed);
            PanelFromulario1.Controls.Add(CbAlegiaMedi);
            PanelFromulario1.Controls.Add(tbExpliEnfer);
            PanelFromulario1.Controls.Add(CbEnfermedad);
            PanelFromulario1.Controls.Add(label4);
            PanelFromulario1.Controls.Add(TbApellido);
            PanelFromulario1.Controls.Add(TbTele);
            PanelFromulario1.Controls.Add(DtNacimiendo);
            PanelFromulario1.Controls.Add(tbEdad);
            PanelFromulario1.Controls.Add(label3);
            PanelFromulario1.Controls.Add(PbSiguiente);
            PanelFromulario1.Controls.Add(tbCedula);
            PanelFromulario1.Controls.Add(tbNombre);
            PanelFromulario1.Controls.Add(tbDireccion);
            PanelFromulario1.Controls.Add(cbSexo);
            PanelFromulario1.Location = new Point(22, 246);
            PanelFromulario1.Name = "PanelFromulario1";
            PanelFromulario1.Size = new Size(895, 708);
            PanelFromulario1.TabIndex = 1010;
            // 
            // TbAlch
            // 
            TbAlch.BackColor = SystemColors.ControlLight;
            TbAlch.Cursor = Cursors.IBeam;
            TbAlch.Enabled = false;
            TbAlch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbAlch.Location = new Point(190, 568);
            TbAlch.Margin = new Padding(5);
            TbAlch.Name = "TbAlch";
            TbAlch.PlaceholderText = "Explique";
            TbAlch.Size = new Size(681, 26);
            TbAlch.TabIndex = 1034;
            TbAlch.Text = "Niega";
            // 
            // TbFisica
            // 
            TbFisica.BackColor = SystemColors.ControlLight;
            TbFisica.Cursor = Cursors.IBeam;
            TbFisica.Enabled = false;
            TbFisica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbFisica.Location = new Point(190, 539);
            TbFisica.Margin = new Padding(5);
            TbFisica.Name = "TbFisica";
            TbFisica.PlaceholderText = "Explique";
            TbFisica.Size = new Size(681, 26);
            TbFisica.TabIndex = 1033;
            TbFisica.Text = "Niega";
            // 
            // TbTabaquis
            // 
            TbTabaquis.BackColor = SystemColors.ControlLight;
            TbTabaquis.Cursor = Cursors.IBeam;
            TbTabaquis.Enabled = false;
            TbTabaquis.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbTabaquis.Location = new Point(190, 510);
            TbTabaquis.Margin = new Padding(5);
            TbTabaquis.Name = "TbTabaquis";
            TbTabaquis.PlaceholderText = "Explique";
            TbTabaquis.Size = new Size(681, 26);
            TbTabaquis.TabIndex = 1031;
            TbTabaquis.Text = "Niega";
            // 
            // TbOcupa
            // 
            TbOcupa.BackColor = SystemColors.ControlLight;
            TbOcupa.Cursor = Cursors.IBeam;
            TbOcupa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbOcupa.Location = new Point(27, 656);
            TbOcupa.Margin = new Padding(5);
            TbOcupa.Name = "TbOcupa";
            TbOcupa.PlaceholderText = "Ocupación";
            TbOcupa.Size = new Size(720, 26);
            TbOcupa.TabIndex = 1030;
            // 
            // TbOtros
            // 
            TbOtros.BackColor = SystemColors.ControlLight;
            TbOtros.Cursor = Cursors.IBeam;
            TbOtros.Enabled = false;
            TbOtros.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbOtros.Location = new Point(190, 598);
            TbOtros.Margin = new Padding(5);
            TbOtros.Name = "TbOtros";
            TbOtros.PlaceholderText = "Explique";
            TbOtros.Size = new Size(681, 26);
            TbOtros.TabIndex = 1029;
            TbOtros.Text = "Niega";
            // 
            // CbTaba
            // 
            CbTaba.AutoSize = true;
            CbTaba.CheckAlign = ContentAlignment.MiddleRight;
            CbTaba.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbTaba.ForeColor = SystemColors.ControlLightLight;
            CbTaba.Location = new Point(23, 513);
            CbTaba.Name = "CbTaba";
            CbTaba.Size = new Size(156, 23);
            CbTaba.TabIndex = 1028;
            CbTaba.Text = "Tabaquismo:       ";
            CbTaba.TextAlign = ContentAlignment.MiddleCenter;
            CbTaba.UseVisualStyleBackColor = true;
            CbTaba.CheckedChanged += CbTaba_CheckedChanged;
            // 
            // CbAlcho
            // 
            CbAlcho.AutoSize = true;
            CbAlcho.CheckAlign = ContentAlignment.MiddleRight;
            CbAlcho.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbAlcho.ForeColor = SystemColors.ControlLightLight;
            CbAlcho.Location = new Point(27, 571);
            CbAlcho.Name = "CbAlcho";
            CbAlcho.Size = new Size(152, 23);
            CbAlcho.TabIndex = 1027;
            CbAlcho.Text = "Alcohol:               ";
            CbAlcho.TextAlign = ContentAlignment.MiddleCenter;
            CbAlcho.UseVisualStyleBackColor = true;
            CbAlcho.CheckedChanged += CbAlcho_CheckedChanged;
            // 
            // CbFisica
            // 
            CbFisica.AutoSize = true;
            CbFisica.CheckAlign = ContentAlignment.MiddleRight;
            CbFisica.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbFisica.ForeColor = SystemColors.ControlLightLight;
            CbFisica.Location = new Point(27, 542);
            CbFisica.Name = "CbFisica";
            CbFisica.Size = new Size(154, 23);
            CbFisica.TabIndex = 1026;
            CbFisica.Text = "Actividad Física:";
            CbFisica.TextAlign = ContentAlignment.MiddleCenter;
            CbFisica.UseVisualStyleBackColor = true;
            CbFisica.CheckedChanged += CbFisica_CheckedChanged;
            // 
            // CbOtro
            // 
            CbOtro.AutoSize = true;
            CbOtro.CheckAlign = ContentAlignment.MiddleRight;
            CbOtro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbOtro.ForeColor = SystemColors.ControlLightLight;
            CbOtro.Location = new Point(27, 600);
            CbOtro.Name = "CbOtro";
            CbOtro.Size = new Size(151, 23);
            CbOtro.TabIndex = 1025;
            CbOtro.Text = "Estrés:                 ";
            CbOtro.TextAlign = ContentAlignment.MiddleCenter;
            CbOtro.UseVisualStyleBackColor = true;
            CbOtro.CheckedChanged += CbOtro_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(217, 465);
            label5.Name = "label5";
            label5.Size = new Size(499, 40);
            label5.TabIndex = 1024;
            label5.Text = "HÁBITOS PSICOBIOLÓGICOS";
            // 
            // tbExpliBio
            // 
            tbExpliBio.BackColor = SystemColors.ControlLight;
            tbExpliBio.Cursor = Cursors.IBeam;
            tbExpliBio.Enabled = false;
            tbExpliBio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbExpliBio.Location = new Point(233, 415);
            tbExpliBio.Margin = new Padding(5);
            tbExpliBio.Name = "tbExpliBio";
            tbExpliBio.PlaceholderText = "Explique";
            tbExpliBio.Size = new Size(637, 26);
            tbExpliBio.TabIndex = 1023;
            tbExpliBio.Text = "Niega";
            // 
            // CbBiopoli
            // 
            CbBiopoli.AutoSize = true;
            CbBiopoli.CheckAlign = ContentAlignment.MiddleRight;
            CbBiopoli.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbBiopoli.ForeColor = SystemColors.ControlLightLight;
            CbBiopoli.Location = new Point(17, 418);
            CbBiopoli.Name = "CbBiopoli";
            CbBiopoli.Size = new Size(208, 23);
            CbBiopoli.TabIndex = 1022;
            CbBiopoli.Text = "Biopolímeros:                  ";
            CbBiopoli.TextAlign = ContentAlignment.MiddleCenter;
            CbBiopoli.UseVisualStyleBackColor = true;
            CbBiopoli.CheckedChanged += CbBiopoli_CheckedChanged;
            // 
            // TbExpliTrata
            // 
            TbExpliTrata.BackColor = SystemColors.ControlLight;
            TbExpliTrata.Cursor = Cursors.IBeam;
            TbExpliTrata.Enabled = false;
            TbExpliTrata.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbExpliTrata.Location = new Point(233, 379);
            TbExpliTrata.Margin = new Padding(5);
            TbExpliTrata.Name = "TbExpliTrata";
            TbExpliTrata.PlaceholderText = "Explique";
            TbExpliTrata.Size = new Size(637, 26);
            TbExpliTrata.TabIndex = 1021;
            TbExpliTrata.Text = "Niega";
            // 
            // CbTrata
            // 
            CbTrata.AutoSize = true;
            CbTrata.CheckAlign = ContentAlignment.MiddleRight;
            CbTrata.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbTrata.ForeColor = SystemColors.ControlLightLight;
            CbTrata.Location = new Point(17, 382);
            CbTrata.Name = "CbTrata";
            CbTrata.Size = new Size(206, 23);
            CbTrata.TabIndex = 1020;
            CbTrata.Text = "Tratamientos estéticos:";
            CbTrata.TextAlign = ContentAlignment.MiddleCenter;
            CbTrata.UseVisualStyleBackColor = true;
            CbTrata.CheckedChanged += CbTrata_CheckedChanged;
            // 
            // TbExpliCiru
            // 
            TbExpliCiru.BackColor = SystemColors.ControlLight;
            TbExpliCiru.Cursor = Cursors.IBeam;
            TbExpliCiru.Enabled = false;
            TbExpliCiru.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbExpliCiru.Location = new Point(233, 343);
            TbExpliCiru.Margin = new Padding(5);
            TbExpliCiru.Name = "TbExpliCiru";
            TbExpliCiru.PlaceholderText = "Explique";
            TbExpliCiru.Size = new Size(637, 26);
            TbExpliCiru.TabIndex = 1019;
            TbExpliCiru.Text = "Niega";
            // 
            // CbCiru
            // 
            CbCiru.AutoSize = true;
            CbCiru.CheckAlign = ContentAlignment.MiddleRight;
            CbCiru.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbCiru.ForeColor = SystemColors.ControlLightLight;
            CbCiru.Location = new Point(17, 346);
            CbCiru.Name = "CbCiru";
            CbCiru.Size = new Size(206, 23);
            CbCiru.TabIndex = 1018;
            CbCiru.Text = "Cirugias:                           ";
            CbCiru.TextAlign = ContentAlignment.MiddleCenter;
            CbCiru.UseVisualStyleBackColor = true;
            CbCiru.CheckedChanged += CbCiru_CheckedChanged;
            // 
            // TbExpliAlergAli
            // 
            TbExpliAlergAli.BackColor = SystemColors.ControlLight;
            TbExpliAlergAli.Cursor = Cursors.IBeam;
            TbExpliAlergAli.Enabled = false;
            TbExpliAlergAli.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbExpliAlergAli.Location = new Point(233, 307);
            TbExpliAlergAli.Margin = new Padding(5);
            TbExpliAlergAli.Name = "TbExpliAlergAli";
            TbExpliAlergAli.PlaceholderText = "Explique";
            TbExpliAlergAli.Size = new Size(637, 26);
            TbExpliAlergAli.TabIndex = 1017;
            TbExpliAlergAli.Text = "Niega";
            // 
            // CbAlergiAli
            // 
            CbAlergiAli.AutoSize = true;
            CbAlergiAli.CheckAlign = ContentAlignment.MiddleRight;
            CbAlergiAli.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbAlergiAli.ForeColor = SystemColors.ControlLightLight;
            CbAlergiAli.Location = new Point(17, 310);
            CbAlergiAli.Name = "CbAlergiAli";
            CbAlergiAli.Size = new Size(206, 23);
            CbAlergiAli.TabIndex = 1016;
            CbAlergiAli.Text = "Alergia Alimentos:          ";
            CbAlergiAli.TextAlign = ContentAlignment.MiddleCenter;
            CbAlergiAli.UseVisualStyleBackColor = true;
            CbAlergiAli.CheckedChanged += CbAlergiAli_CheckedChanged;
            // 
            // TbExplAlergiaMed
            // 
            TbExplAlergiaMed.BackColor = SystemColors.ControlLight;
            TbExplAlergiaMed.Cursor = Cursors.IBeam;
            TbExplAlergiaMed.Enabled = false;
            TbExplAlergiaMed.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbExplAlergiaMed.Location = new Point(233, 271);
            TbExplAlergiaMed.Margin = new Padding(5);
            TbExplAlergiaMed.Name = "TbExplAlergiaMed";
            TbExplAlergiaMed.PlaceholderText = "Explique";
            TbExplAlergiaMed.Size = new Size(637, 26);
            TbExplAlergiaMed.TabIndex = 1015;
            TbExplAlergiaMed.Text = "Niega";
            // 
            // CbAlegiaMedi
            // 
            CbAlegiaMedi.AutoSize = true;
            CbAlegiaMedi.CheckAlign = ContentAlignment.MiddleRight;
            CbAlegiaMedi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbAlegiaMedi.ForeColor = SystemColors.ControlLightLight;
            CbAlegiaMedi.Location = new Point(17, 274);
            CbAlegiaMedi.Name = "CbAlegiaMedi";
            CbAlegiaMedi.Size = new Size(206, 23);
            CbAlegiaMedi.TabIndex = 1014;
            CbAlegiaMedi.Text = "Alergia Medicamentos: ";
            CbAlegiaMedi.TextAlign = ContentAlignment.MiddleCenter;
            CbAlegiaMedi.UseVisualStyleBackColor = true;
            CbAlegiaMedi.CheckedChanged += CbAlegiaMedi_CheckedChanged;
            // 
            // tbExpliEnfer
            // 
            tbExpliEnfer.BackColor = SystemColors.ControlLight;
            tbExpliEnfer.Cursor = Cursors.IBeam;
            tbExpliEnfer.Enabled = false;
            tbExpliEnfer.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbExpliEnfer.Location = new Point(233, 235);
            tbExpliEnfer.Margin = new Padding(5);
            tbExpliEnfer.Name = "tbExpliEnfer";
            tbExpliEnfer.PlaceholderText = "Explique";
            tbExpliEnfer.Size = new Size(637, 26);
            tbExpliEnfer.TabIndex = 1013;
            tbExpliEnfer.Text = "Niega";
            // 
            // CbEnfermedad
            // 
            CbEnfermedad.AutoSize = true;
            CbEnfermedad.CheckAlign = ContentAlignment.MiddleRight;
            CbEnfermedad.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbEnfermedad.ForeColor = SystemColors.ControlLightLight;
            CbEnfermedad.Location = new Point(17, 238);
            CbEnfermedad.Name = "CbEnfermedad";
            CbEnfermedad.Size = new Size(208, 23);
            CbEnfermedad.TabIndex = 1012;
            CbEnfermedad.Text = "Enfermedad crónica:     ";
            CbEnfermedad.TextAlign = ContentAlignment.MiddleCenter;
            CbEnfermedad.UseVisualStyleBackColor = true;
            CbEnfermedad.CheckedChanged += CbEnfermedad_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(189, 176);
            label4.Name = "label4";
            label4.Size = new Size(541, 40);
            label4.TabIndex = 1011;
            label4.Text = "ANTECEDENTES PERSONALES";
            // 
            // TbApellido
            // 
            TbApellido.BackColor = SystemColors.ControlLight;
            TbApellido.Cursor = Cursors.IBeam;
            TbApellido.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbApellido.Location = new Point(342, 45);
            TbApellido.Margin = new Padding(5);
            TbApellido.Name = "TbApellido";
            TbApellido.PlaceholderText = "Apellidos";
            TbApellido.Size = new Size(317, 26);
            TbApellido.TabIndex = 2;
            // 
            // TbTele
            // 
            TbTele.BackColor = SystemColors.ControlLight;
            TbTele.Cursor = Cursors.IBeam;
            TbTele.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbTele.Location = new Point(454, 79);
            TbTele.Margin = new Padding(5);
            TbTele.Name = "TbTele";
            TbTele.PlaceholderText = "Teléfono";
            TbTele.Size = new Size(206, 26);
            TbTele.TabIndex = 6;
            TbTele.TextChanged += TbTele_TextChanged;
            // 
            // DtNacimiendo
            // 
            DtNacimiendo.CalendarMonthBackground = SystemColors.ControlLight;
            DtNacimiendo.Cursor = Cursors.IBeam;
            DtNacimiendo.CustomFormat = "\"dd/MM/yyyy\"";
            DtNacimiendo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtNacimiendo.Format = DateTimePickerFormat.Short;
            DtNacimiendo.Location = new Point(22, 79);
            DtNacimiendo.Name = "DtNacimiendo";
            DtNacimiendo.RightToLeft = RightToLeft.Yes;
            DtNacimiendo.Size = new Size(206, 26);
            DtNacimiendo.TabIndex = 4;
            DtNacimiendo.ValueChanged += DtNacimiendo_ValueChanged;
            // 
            // tbEdad
            // 
            tbEdad.BackColor = SystemColors.ControlLight;
            tbEdad.Enabled = false;
            tbEdad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEdad.Location = new Point(238, 79);
            tbEdad.Name = "tbEdad";
            tbEdad.PlaceholderText = "Edad";
            tbEdad.Size = new Size(206, 26);
            tbEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(275, 0);
            label3.Name = "label3";
            label3.Size = new Size(375, 40);
            label3.TabIndex = 1010;
            label3.Text = "DATOS PERSONALES";
            // 
            // PanelFromulario2
            // 
            PanelFromulario2.BackColor = Color.Transparent;
            PanelFromulario2.Controls.Add(DtTratamiento);
            PanelFromulario2.Controls.Add(LbPaciente);
            PanelFromulario2.Controls.Add(RbGuardar);
            PanelFromulario2.Controls.Add(PbBorrar);
            PanelFromulario2.Controls.Add(BbAtras);
            PanelFromulario2.Controls.Add(label8);
            PanelFromulario2.Controls.Add(PbAgregar);
            PanelFromulario2.Controls.Add(label7);
            PanelFromulario2.Controls.Add(RtDescriTrata);
            PanelFromulario2.Controls.Add(label6);
            PanelFromulario2.Controls.Add(CbTratamientos);
            PanelFromulario2.Controls.Add(RtHistoTratamiento);
            PanelFromulario2.Controls.Add(label2);
            PanelFromulario2.Controls.Add(RtExamenFisico);
            PanelFromulario2.Controls.Add(label1);
            PanelFromulario2.Location = new Point(22, 246);
            PanelFromulario2.Name = "PanelFromulario2";
            PanelFromulario2.Size = new Size(895, 709);
            PanelFromulario2.TabIndex = 1011;
            // 
            // DtTratamiento
            // 
            DtTratamiento.CalendarMonthBackground = SystemColors.ControlLight;
            DtTratamiento.Cursor = Cursors.IBeam;
            DtTratamiento.CustomFormat = "\"dd/MM/yyyy\"";
            DtTratamiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtTratamiento.Format = DateTimePickerFormat.Short;
            DtTratamiento.Location = new Point(60, 262);
            DtTratamiento.Name = "DtTratamiento";
            DtTratamiento.RightToLeft = RightToLeft.Yes;
            DtTratamiento.Size = new Size(179, 26);
            DtTratamiento.TabIndex = 1023;
            // 
            // LbPaciente
            // 
            LbPaciente.AutoSize = true;
            LbPaciente.Font = new Font("Arial", 15F, FontStyle.Bold);
            LbPaciente.ForeColor = SystemColors.Control;
            LbPaciente.Location = new Point(126, 642);
            LbPaciente.Name = "LbPaciente";
            LbPaciente.Size = new Size(0, 24);
            LbPaciente.TabIndex = 1021;
            LbPaciente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RbGuardar
            // 
            RbGuardar.Cursor = Cursors.Hand;
            RbGuardar.ErrorImage = (Image)resources.GetObject("RbGuardar.ErrorImage");
            RbGuardar.Image = Properties.Resources.Guardar;
            RbGuardar.Location = new Point(721, 634);
            RbGuardar.Name = "RbGuardar";
            RbGuardar.Size = new Size(138, 63);
            RbGuardar.SizeMode = PictureBoxSizeMode.StretchImage;
            RbGuardar.TabIndex = 1022;
            RbGuardar.TabStop = false;
            RbGuardar.Click += RbGuardar_Click;
            // 
            // PbBorrar
            // 
            PbBorrar.Cursor = Cursors.Hand;
            PbBorrar.ErrorImage = (Image)resources.GetObject("PbBorrar.ErrorImage");
            PbBorrar.Image = Properties.Resources.borrar;
            PbBorrar.Location = new Point(156, 294);
            PbBorrar.Name = "PbBorrar";
            PbBorrar.Size = new Size(102, 49);
            PbBorrar.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBorrar.TabIndex = 1021;
            PbBorrar.TabStop = false;
            PbBorrar.Click += PbBorrar_Click;
            // 
            // BbAtras
            // 
            BbAtras.Cursor = Cursors.Hand;
            BbAtras.ErrorImage = (Image)resources.GetObject("BbAtras.ErrorImage");
            BbAtras.Image = Properties.Resources.flachaIsquierda;
            BbAtras.Location = new Point(26, 617);
            BbAtras.Name = "BbAtras";
            BbAtras.Size = new Size(85, 80);
            BbAtras.SizeMode = PictureBoxSizeMode.StretchImage;
            BbAtras.TabIndex = 1010;
            BbAtras.TabStop = false;
            BbAtras.Click += BbAtras_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(189, 372);
            label8.Name = "label8";
            label8.Size = new Size(511, 40);
            label8.TabIndex = 1020;
            label8.Text = "HISTÓRICO DE TRATAMIENTO";
            // 
            // PbAgregar
            // 
            PbAgregar.Cursor = Cursors.Hand;
            PbAgregar.ErrorImage = (Image)resources.GetObject("PbAgregar.ErrorImage");
            PbAgregar.Image = Properties.Resources.agregar;
            PbAgregar.Location = new Point(48, 294);
            PbAgregar.Name = "PbAgregar";
            PbAgregar.Size = new Size(102, 49);
            PbAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            PbAgregar.TabIndex = 1019;
            PbAgregar.TabStop = false;
            PbAgregar.Click += PbAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(275, 215);
            label7.Name = "label7";
            label7.Size = new Size(164, 15);
            label7.TabIndex = 1018;
            label7.Text = "Descripción del tratamiento";
            // 
            // RtDescriTrata
            // 
            RtDescriTrata.BackColor = SystemColors.ControlLight;
            RtDescriTrata.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtDescriTrata.Location = new Point(275, 233);
            RtDescriTrata.Name = "RtDescriTrata";
            RtDescriTrata.Size = new Size(595, 52);
            RtDescriTrata.TabIndex = 1017;
            RtDescriTrata.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(33, 215);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 1016;
            label6.Text = "Tipo de tratamiento";
            // 
            // CbTratamientos
            // 
            CbTratamientos.AutoCompleteMode = AutoCompleteMode.Append;
            CbTratamientos.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbTratamientos.DropDownStyle = ComboBoxStyle.DropDownList;
            CbTratamientos.FormattingEnabled = true;
            CbTratamientos.Items.AddRange(new object[] { "sdfg6454rty", "sd345e4tfgh", "fgsd23fsdfher5y23", "4asdfasdf", "4aer3sdfgghntyuj", "5erfhgdfhrtyfc", "tyrqwsdfgdfervc", "gdcvxbxgfhfgh" });
            CbTratamientos.Location = new Point(33, 233);
            CbTratamientos.Name = "CbTratamientos";
            CbTratamientos.Size = new Size(236, 23);
            CbTratamientos.TabIndex = 1015;
            // 
            // RtHistoTratamiento
            // 
            RtHistoTratamiento.BackColor = SystemColors.ControlLight;
            RtHistoTratamiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtHistoTratamiento.Location = new Point(22, 418);
            RtHistoTratamiento.Name = "RtHistoTratamiento";
            RtHistoTratamiento.ReadOnly = true;
            RtHistoTratamiento.Size = new Size(848, 189);
            RtHistoTratamiento.TabIndex = 1014;
            RtHistoTratamiento.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(311, 150);
            label2.Name = "label2";
            label2.Size = new Size(279, 40);
            label2.TabIndex = 1013;
            label2.Text = "TRATAMIENTOS";
            // 
            // RtExamenFisico
            // 
            RtExamenFisico.BackColor = SystemColors.ControlLight;
            RtExamenFisico.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtExamenFisico.Location = new Point(33, 59);
            RtExamenFisico.Name = "RtExamenFisico";
            RtExamenFisico.Size = new Size(837, 52);
            RtExamenFisico.TabIndex = 1012;
            RtExamenFisico.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(311, 0);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 1011;
            label1.Text = "EXÁMEN FÍSICO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Membrete;
            pictureBox2.Location = new Point(0, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(934, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1012;
            pictureBox2.TabStop = false;
            // 
            // PanelFromulario3
            // 
            PanelFromulario3.BackColor = Color.Transparent;
            PanelFromulario3.Controls.Add(TbBuscar);
            PanelFromulario3.Controls.Add(GvConsulta);
            PanelFromulario3.Location = new Point(22, 246);
            PanelFromulario3.Name = "PanelFromulario3";
            PanelFromulario3.Size = new Size(895, 709);
            PanelFromulario3.TabIndex = 1014;
            // 
            // TbBuscar
            // 
            TbBuscar.BackColor = SystemColors.ControlLight;
            TbBuscar.Cursor = Cursors.IBeam;
            TbBuscar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbBuscar.Location = new Point(288, 115);
            TbBuscar.Margin = new Padding(5);
            TbBuscar.Name = "TbBuscar";
            TbBuscar.PlaceholderText = "Buscar paciente";
            TbBuscar.Size = new Size(310, 26);
            TbBuscar.TabIndex = 2;
            TbBuscar.KeyDown += TbBuscar_KeyDown;
            // 
            // GvConsulta
            // 
            GvConsulta.AllowUserToOrderColumns = true;
            GvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GvConsulta.BorderStyle = BorderStyle.Fixed3D;
            GvConsulta.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            GvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvConsulta.Columns.AddRange(new DataGridViewColumn[] { BtnImprimir, BtnEliminar });
            GvConsulta.Location = new Point(33, 176);
            GvConsulta.Name = "GvConsulta";
            GvConsulta.ReadOnly = true;
            GvConsulta.SelectionMode = DataGridViewSelectionMode.CellSelect;
            GvConsulta.Size = new Size(826, 418);
            GvConsulta.TabIndex = 0;
            GvConsulta.CellContentClick += GvConsulta_BtnImprimir_Click;
            GvConsulta.CellDoubleClick += GvConsulta_CellContentClick;
            // 
            // BtnImprimir
            // 
            BtnImprimir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            BtnImprimir.DefaultCellStyle = dataGridViewCellStyle1;
            BtnImprimir.HeaderText = "Imprimir";
            BtnImprimir.MinimumWidth = 7;
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.ReadOnly = true;
            BtnImprimir.Resizable = DataGridViewTriState.True;
            BtnImprimir.Text = "Consentimiento";
            BtnImprimir.ToolTipText = "Consentimiento";
            BtnImprimir.UseColumnTextForButtonValue = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 128, 128);
            BtnEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            BtnEliminar.HeaderText = "Borrar";
            BtnEliminar.MinimumWidth = 7;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.ReadOnly = true;
            BtnEliminar.Text = "Borrar";
            BtnEliminar.ToolTipText = "Borrar";
            BtnEliminar.UseColumnTextForButtonValue = true;
            BtnEliminar.Width = 75;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // PbGaleria
            // 
            PbGaleria.BackColor = Color.Transparent;
            PbGaleria.Cursor = Cursors.Hand;
            PbGaleria.ErrorImage = (Image)resources.GetObject("PbGaleria.ErrorImage");
            PbGaleria.Image = Properties.Resources.galeria;
            PbGaleria.Location = new Point(845, 55);
            PbGaleria.Name = "PbGaleria";
            PbGaleria.Size = new Size(72, 60);
            PbGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            PbGaleria.TabIndex = 1023;
            PbGaleria.TabStop = false;
            PbGaleria.Visible = false;
            PbGaleria.Click += PbGaleria_Click;
            // 
            // PbRostro
            // 
            PbRostro.BackColor = Color.Transparent;
            PbRostro.Cursor = Cursors.Hand;
            PbRostro.ErrorImage = Properties.Resources.Rostro;
            PbRostro.Image = Properties.Resources.Rostro;
            PbRostro.Location = new Point(3, 39);
            PbRostro.Name = "PbRostro";
            PbRostro.Size = new Size(145, 183);
            PbRostro.SizeMode = PictureBoxSizeMode.StretchImage;
            PbRostro.TabIndex = 1025;
            PbRostro.TabStop = false;
            PbRostro.Visible = false;
            PbRostro.Click += PbRostro_Click;
            // 
            // UcPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.fondo;
            Controls.Add(PbRostro);
            Controls.Add(PbGaleria);
            Controls.Add(pictureBox2);
            Controls.Add(PanelFromulario2);
            Controls.Add(PanelFromulario1);
            Controls.Add(PanelFromulario3);
            MaximumSize = new Size(955, 1000);
            MinimumSize = new Size(955, 0);
            Name = "UcPacientes";
            Size = new Size(955, 965);
            ((System.ComponentModel.ISupportInitialize)PbSiguiente).EndInit();
            PanelFromulario1.ResumeLayout(false);
            PanelFromulario1.PerformLayout();
            PanelFromulario2.ResumeLayout(false);
            PanelFromulario2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BbAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelFromulario3.ResumeLayout(false);
            PanelFromulario3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GvConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbGaleria).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbRostro).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public TextBox tbNombre;
        public TextBox tbDireccion;
        public ComboBox cbSexo;
        public TextBox tbCedula;
        public PictureBox PbSiguiente;
        public Panel PanelFromulario1;
        public Panel PanelFromulario2;
        public PictureBox pictureBox2;
        public Label label3;
        public DateTimePicker DtNacimiendo;
        public TextBox tbEdad;
        public TextBox TbTele;
        public TextBox TbApellido;
        public Label label4;
        public CheckBox CbEnfermedad;
        public TextBox tbExpliEnfer;
        public TextBox TbExplAlergiaMed;
        public CheckBox CbAlegiaMedi;
        public TextBox TbExpliAlergAli;
        public CheckBox CbAlergiAli;
        public TextBox TbExpliCiru;
        public CheckBox CbCiru;
        public TextBox tbExpliBio;
        public CheckBox CbBiopoli;
        public TextBox TbExpliTrata;
        public CheckBox CbTrata;
        public CheckBox CbTaba;
        public CheckBox CbAlcho;
        public CheckBox CbFisica;
        public CheckBox CbOtro;
        public Label label5;
        public TextBox TbOtros;
        public TextBox TbOcupa;
        public TextBox TbAlch;
        public TextBox TbFisica;
        public TextBox TbTabaquis;
        public PictureBox BbAtras;
        public Label label1;
        public RichTextBox RtExamenFisico;
        public Label label2;
        public ComboBox CbTratamientos;
        public Label label7;
        public RichTextBox RtDescriTrata;
        public Label label6;
        public PictureBox PbAgregar;
        public Label label8;
        public PictureBox PbBorrar;
        public RichTextBox RtHistoTratamiento;
        public PictureBox RbGuardar;
        public Panel PanelFromulario3;
        public DataGridView GvConsulta;
        public TextBox TbBuscar;
        public Label LbPaciente;
        public Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        public PictureBox PbGaleria;
        private ImageList IlGaleria;
        public PictureBox PbRostro;
        private DataGridViewButtonColumn BtnImprimir;
        private DataGridViewButtonColumn BtnEliminar;
        public DateTimePicker DtTratamiento;
    }
}