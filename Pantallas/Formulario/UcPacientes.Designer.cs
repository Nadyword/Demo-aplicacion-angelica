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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPacientes));
            tbNombre = new TextBox();
            tb = new TextBox();
            cbSexo = new ComboBox();
            tbCedula = new TextBox();
            PbSiguiente = new PictureBox();
            PanelFromulario = new Panel();
            TbAlch = new TextBox();
            TbFisica = new TextBox();
            TbTabaquis = new TextBox();
            TxOcupa = new TextBox();
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
            PanelContrato = new Panel();
            label8 = new Label();
            PbAgregar = new PictureBox();
            label7 = new Label();
            RtDescriTrata = new RichTextBox();
            label6 = new Label();
            CbTratamientos = new ComboBox();
            RtHistoTratamiento = new RichTextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            BbAtras = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PbSiguiente).BeginInit();
            PanelFromulario.SuspendLayout();
            PanelContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BbAtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.ControlLight;
            tbNombre.Cursor = Cursors.IBeam;
            tbNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNombre.Location = new Point(22, 82);
            tbNombre.Margin = new Padding(5);
            tbNombre.Name = "tbNombre";
            tbNombre.PlaceholderText = "Nombres";
            tbNombre.Size = new Size(310, 26);
            tbNombre.TabIndex = 1;
            // 
            // tb
            // 
            tb.BackColor = SystemColors.ControlLight;
            tb.Cursor = Cursors.IBeam;
            tb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb.Location = new Point(22, 150);
            tb.Margin = new Padding(5);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.PlaceholderText = "Dirección";
            tb.Size = new Size(853, 46);
            tb.TabIndex = 8;
            // 
            // cbSexo
            // 
            cbSexo.BackColor = SystemColors.ControlLight;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "< Sexo >", "Masculino", "Femenino" });
            cbSexo.Location = new Point(669, 116);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(206, 26);
            cbSexo.TabIndex = 7;
            // 
            // tbCedula
            // 
            tbCedula.BackColor = SystemColors.ControlLight;
            tbCedula.Cursor = Cursors.IBeam;
            tbCedula.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCedula.Location = new Point(669, 82);
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
            PbSiguiente.Location = new Point(785, 669);
            PbSiguiente.Name = "PbSiguiente";
            PbSiguiente.Size = new Size(85, 80);
            PbSiguiente.SizeMode = PictureBoxSizeMode.StretchImage;
            PbSiguiente.TabIndex = 1009;
            PbSiguiente.TabStop = false;
            PbSiguiente.Click += PbSiguiente_Click;
            // 
            // PanelFromulario
            // 
            PanelFromulario.BackColor = Color.Transparent;
            PanelFromulario.Controls.Add(TbAlch);
            PanelFromulario.Controls.Add(TbFisica);
            PanelFromulario.Controls.Add(TbTabaquis);
            PanelFromulario.Controls.Add(TxOcupa);
            PanelFromulario.Controls.Add(TbOtros);
            PanelFromulario.Controls.Add(CbTaba);
            PanelFromulario.Controls.Add(CbAlcho);
            PanelFromulario.Controls.Add(CbFisica);
            PanelFromulario.Controls.Add(CbOtro);
            PanelFromulario.Controls.Add(label5);
            PanelFromulario.Controls.Add(tbExpliBio);
            PanelFromulario.Controls.Add(CbBiopoli);
            PanelFromulario.Controls.Add(TbExpliTrata);
            PanelFromulario.Controls.Add(CbTrata);
            PanelFromulario.Controls.Add(TbExpliCiru);
            PanelFromulario.Controls.Add(CbCiru);
            PanelFromulario.Controls.Add(TbExpliAlergAli);
            PanelFromulario.Controls.Add(CbAlergiAli);
            PanelFromulario.Controls.Add(TbExplAlergiaMed);
            PanelFromulario.Controls.Add(CbAlegiaMedi);
            PanelFromulario.Controls.Add(tbExpliEnfer);
            PanelFromulario.Controls.Add(CbEnfermedad);
            PanelFromulario.Controls.Add(label4);
            PanelFromulario.Controls.Add(TbApellido);
            PanelFromulario.Controls.Add(TbTele);
            PanelFromulario.Controls.Add(DtNacimiendo);
            PanelFromulario.Controls.Add(tbEdad);
            PanelFromulario.Controls.Add(label3);
            PanelFromulario.Controls.Add(PbSiguiente);
            PanelFromulario.Controls.Add(tbCedula);
            PanelFromulario.Controls.Add(tbNombre);
            PanelFromulario.Controls.Add(tb);
            PanelFromulario.Controls.Add(cbSexo);
            PanelFromulario.Location = new Point(25, 193);
            PanelFromulario.Name = "PanelFromulario";
            PanelFromulario.Size = new Size(895, 770);
            PanelFromulario.TabIndex = 1010;
            // 
            // TbAlch
            // 
            TbAlch.BackColor = SystemColors.ControlLight;
            TbAlch.Cursor = Cursors.IBeam;
            TbAlch.Enabled = false;
            TbAlch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbAlch.Location = new Point(189, 608);
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
            TbFisica.Location = new Point(189, 579);
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
            TbTabaquis.Location = new Point(189, 550);
            TbTabaquis.Margin = new Padding(5);
            TbTabaquis.Name = "TbTabaquis";
            TbTabaquis.PlaceholderText = "Explique";
            TbTabaquis.Size = new Size(681, 26);
            TbTabaquis.TabIndex = 1031;
            TbTabaquis.Text = "Niega";
            // 
            // TxOcupa
            // 
            TxOcupa.BackColor = SystemColors.ControlLight;
            TxOcupa.Cursor = Cursors.IBeam;
            TxOcupa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxOcupa.Location = new Point(26, 696);
            TxOcupa.Margin = new Padding(5);
            TxOcupa.Name = "TxOcupa";
            TxOcupa.PlaceholderText = "Ocupación";
            TxOcupa.Size = new Size(720, 26);
            TxOcupa.TabIndex = 1030;
            // 
            // TbOtros
            // 
            TbOtros.BackColor = SystemColors.ControlLight;
            TbOtros.Cursor = Cursors.IBeam;
            TbOtros.Enabled = false;
            TbOtros.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbOtros.Location = new Point(189, 638);
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
            CbTaba.Location = new Point(22, 553);
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
            CbAlcho.Location = new Point(26, 611);
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
            CbFisica.Location = new Point(26, 582);
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
            CbOtro.Location = new Point(26, 640);
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
            label5.Location = new Point(216, 505);
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
            tbExpliBio.Location = new Point(233, 452);
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
            CbBiopoli.Location = new Point(17, 455);
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
            TbExpliTrata.Location = new Point(233, 416);
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
            CbTrata.Location = new Point(17, 419);
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
            TbExpliCiru.Location = new Point(233, 380);
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
            CbCiru.Location = new Point(17, 383);
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
            TbExpliAlergAli.Location = new Point(233, 344);
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
            CbAlergiAli.Location = new Point(17, 347);
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
            TbExplAlergiaMed.Location = new Point(233, 308);
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
            CbAlegiaMedi.Location = new Point(17, 311);
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
            tbExpliEnfer.Location = new Point(233, 272);
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
            CbEnfermedad.Location = new Point(17, 275);
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
            label4.Location = new Point(189, 213);
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
            TbApellido.Location = new Point(342, 82);
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
            TbTele.Location = new Point(454, 116);
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
            DtNacimiendo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtNacimiendo.Format = DateTimePickerFormat.Short;
            DtNacimiendo.Location = new Point(22, 116);
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
            tbEdad.Location = new Point(238, 116);
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
            label3.Location = new Point(275, 14);
            label3.Name = "label3";
            label3.Size = new Size(375, 40);
            label3.TabIndex = 1010;
            label3.Text = "DATOS PERSONALES";
            // 
            // PanelContrato
            // 
            PanelContrato.BackColor = Color.Transparent;
            PanelContrato.Controls.Add(label8);
            PanelContrato.Controls.Add(PbAgregar);
            PanelContrato.Controls.Add(label7);
            PanelContrato.Controls.Add(RtDescriTrata);
            PanelContrato.Controls.Add(label6);
            PanelContrato.Controls.Add(CbTratamientos);
            PanelContrato.Controls.Add(RtHistoTratamiento);
            PanelContrato.Controls.Add(label2);
            PanelContrato.Controls.Add(richTextBox1);
            PanelContrato.Controls.Add(label1);
            PanelContrato.Controls.Add(BbAtras);
            PanelContrato.Location = new Point(25, 193);
            PanelContrato.Name = "PanelContrato";
            PanelContrato.Size = new Size(895, 770);
            PanelContrato.TabIndex = 1011;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(189, 376);
            label8.Name = "label8";
            label8.Size = new Size(511, 40);
            label8.TabIndex = 1020;
            label8.Text = "HISTÓRICO DE TRATAMIENTO";
            // 
            // PbAgregar
            // 
            PbAgregar.Cursor = Cursors.Hand;
            PbAgregar.Image = (Image)resources.GetObject("PbAgregar.Image");
            PbAgregar.Location = new Point(75, 285);
            PbAgregar.Name = "PbAgregar";
            PbAgregar.Size = new Size(114, 56);
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
            label7.Location = new Point(275, 238);
            label7.Name = "label7";
            label7.Size = new Size(164, 15);
            label7.TabIndex = 1018;
            label7.Text = "Descripción del tratamiento";
            // 
            // RtDescriTrata
            // 
            RtDescriTrata.BackColor = SystemColors.ControlLight;
            RtDescriTrata.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtDescriTrata.Location = new Point(275, 256);
            RtDescriTrata.Name = "RtDescriTrata";
            RtDescriTrata.Size = new Size(600, 52);
            RtDescriTrata.TabIndex = 1017;
            RtDescriTrata.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(33, 238);
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
            CbTratamientos.Location = new Point(33, 256);
            CbTratamientos.Name = "CbTratamientos";
            CbTratamientos.Size = new Size(209, 23);
            CbTratamientos.TabIndex = 1015;
            // 
            // RtHistoTratamiento
            // 
            RtHistoTratamiento.BackColor = SystemColors.ControlLight;
            RtHistoTratamiento.Enabled = false;
            RtHistoTratamiento.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RtHistoTratamiento.Location = new Point(22, 429);
            RtHistoTratamiento.Name = "RtHistoTratamiento";
            RtHistoTratamiento.Size = new Size(837, 201);
            RtHistoTratamiento.TabIndex = 1014;
            RtHistoTratamiento.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(311, 173);
            label2.Name = "label2";
            label2.Size = new Size(279, 40);
            label2.TabIndex = 1013;
            label2.Text = "TRATAMIENTOS";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLight;
            richTextBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(33, 82);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(837, 52);
            richTextBox1.TabIndex = 1012;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(311, 23);
            label1.Name = "label1";
            label1.Size = new Size(287, 40);
            label1.TabIndex = 1011;
            label1.Text = "EXÁMEN FÍSICO";
            // 
            // BbAtras
            // 
            BbAtras.Cursor = Cursors.Hand;
            BbAtras.Image = (Image)resources.GetObject("BbAtras.Image");
            BbAtras.Location = new Point(26, 638);
            BbAtras.Name = "BbAtras";
            BbAtras.Size = new Size(85, 80);
            BbAtras.SizeMode = PictureBoxSizeMode.StretchImage;
            BbAtras.TabIndex = 1010;
            BbAtras.TabStop = false;
            BbAtras.Click += BbAtras_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(934, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1012;
            pictureBox2.TabStop = false;
            // 
            // UcPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(pictureBox2);
            Controls.Add(PanelContrato);
            Controls.Add(PanelFromulario);
            MaximumSize = new Size(955, 1000);
            MinimumSize = new Size(955, 0);
            Name = "UcPacientes";
            Size = new Size(955, 965);
            ((System.ComponentModel.ISupportInitialize)PbSiguiente).EndInit();
            PanelFromulario.ResumeLayout(false);
            PanelFromulario.PerformLayout();
            PanelContrato.ResumeLayout(false);
            PanelContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BbAtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbNombre;
        private TextBox tb;
        private ComboBox cbSexo;
        private TextBox tbCedula;
        private PictureBox PbSiguiente;
        private Panel PanelFromulario;
        private Panel PanelContrato;
        private PictureBox pictureBox2;
        private Label label3;
        private DateTimePicker DtNacimiendo;
        private TextBox tbEdad;
        private TextBox TbTele;
        private TextBox TbApellido;
        private Label label4;
        private CheckBox CbEnfermedad;
        private TextBox tbExpliEnfer;
        private TextBox TbExplAlergiaMed;
        private CheckBox CbAlegiaMedi;
        private TextBox TbExpliAlergAli;
        private CheckBox CbAlergiAli;
        private TextBox TbExpliCiru;
        private CheckBox CbCiru;
        private TextBox tbExpliBio;
        private CheckBox CbBiopoli;
        private TextBox TbExpliTrata;
        private CheckBox CbTrata;
        private CheckBox CbTaba;
        private CheckBox CbAlcho;
        private CheckBox CbFisica;
        private CheckBox CbOtro;
        private Label label5;
        private TextBox TbOtros;
        private TextBox TxOcupa;
        private TextBox TbAlch;
        private TextBox TbFisica;
        private TextBox TbTabaquis;
        private PictureBox BbAtras;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox RtHistoTratamiento;
        private Label label2;
        private ComboBox CbTratamientos;
        private Label label7;
        private RichTextBox RtDescriTrata;
        private Label label6;
        private PictureBox PbAgregar;
        private Label label8;
    }
}
