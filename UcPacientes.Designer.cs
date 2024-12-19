namespace Demo_aplicacion_angelica_V1
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
            pictureBox1 = new PictureBox();
            PanelFromulario = new Panel();
            TxOcupa = new TextBox();
            TbOtros = new TextBox();
            CbTaba = new CheckBox();
            CbAlcho = new CheckBox();
            checkBox2 = new CheckBox();
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
            lblNombFirma = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelFromulario.SuspendLayout();
            PanelContrato.SuspendLayout();
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
            tb.PlaceholderText = "Direccion";
            tb.Size = new Size(853, 46);
            tb.TabIndex = 8;
            // 
            // cbSexo
            // 
            cbSexo.BackColor = SystemColors.ControlLight;
            cbSexo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "< Sexo >", "Masculino", "Femenino", "OTROS" });
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
            tbCedula.PlaceholderText = "Cedula";
            tbCedula.Size = new Size(206, 26);
            tbCedula.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(736, 627);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 126);
            pictureBox1.TabIndex = 1009;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // PanelFromulario
            // 
            PanelFromulario.BackColor = Color.Transparent;
            PanelFromulario.Controls.Add(TxOcupa);
            PanelFromulario.Controls.Add(TbOtros);
            PanelFromulario.Controls.Add(CbTaba);
            PanelFromulario.Controls.Add(CbAlcho);
            PanelFromulario.Controls.Add(checkBox2);
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
            PanelFromulario.Controls.Add(pictureBox1);
            PanelFromulario.Controls.Add(tbCedula);
            PanelFromulario.Controls.Add(tbNombre);
            PanelFromulario.Controls.Add(tb);
            PanelFromulario.Controls.Add(cbSexo);
            PanelFromulario.Location = new Point(25, 193);
            PanelFromulario.Name = "PanelFromulario";
            PanelFromulario.Size = new Size(895, 770);
            PanelFromulario.TabIndex = 1010;
            // 
            // TxOcupa
            // 
            TxOcupa.BackColor = SystemColors.ControlLight;
            TxOcupa.Cursor = Cursors.IBeam;
            TxOcupa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxOcupa.Location = new Point(22, 642);
            TxOcupa.Margin = new Padding(5);
            TxOcupa.Name = "TxOcupa";
            TxOcupa.PlaceholderText = "Ocupacion";
            TxOcupa.Size = new Size(697, 26);
            TxOcupa.TabIndex = 1030;
            // 
            // TbOtros
            // 
            TbOtros.BackColor = SystemColors.ControlLight;
            TbOtros.Cursor = Cursors.IBeam;
            TbOtros.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbOtros.Location = new Point(454, 599);
            TbOtros.Margin = new Padding(5);
            TbOtros.Name = "TbOtros";
            TbOtros.PlaceholderText = "Explique";
            TbOtros.Size = new Size(421, 26);
            TbOtros.TabIndex = 1029;
            TbOtros.Visible = false;
            // 
            // CbTaba
            // 
            CbTaba.AutoSize = true;
            CbTaba.CheckAlign = ContentAlignment.MiddleRight;
            CbTaba.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbTaba.ForeColor = SystemColors.ControlLightLight;
            CbTaba.Location = new Point(22, 601);
            CbTaba.Name = "CbTaba";
            CbTaba.Size = new Size(128, 23);
            CbTaba.TabIndex = 1028;
            CbTaba.Text = "Tabaquismo:";
            CbTaba.TextAlign = ContentAlignment.MiddleCenter;
            CbTaba.UseVisualStyleBackColor = true;
            // 
            // CbAlcho
            // 
            CbAlcho.AutoSize = true;
            CbAlcho.CheckAlign = ContentAlignment.MiddleRight;
            CbAlcho.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbAlcho.ForeColor = SystemColors.ControlLightLight;
            CbAlcho.Location = new Point(249, 600);
            CbAlcho.Name = "CbAlcho";
            CbAlcho.Size = new Size(92, 23);
            CbAlcho.TabIndex = 1027;
            CbAlcho.Text = "Alcohol:";
            CbAlcho.TextAlign = ContentAlignment.MiddleCenter;
            CbAlcho.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(160, 601);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 23);
            checkBox2.TabIndex = 1026;
            checkBox2.Text = "Física:";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // CbOtro
            // 
            CbOtro.AutoSize = true;
            CbOtro.CheckAlign = ContentAlignment.MiddleRight;
            CbOtro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbOtro.ForeColor = SystemColors.ControlLightLight;
            CbOtro.Location = new Point(352, 600);
            CbOtro.Name = "CbOtro";
            CbOtro.Size = new Size(76, 23);
            CbOtro.TabIndex = 1025;
            CbOtro.Text = "Otros:";
            CbOtro.TextAlign = ContentAlignment.MiddleCenter;
            CbOtro.UseVisualStyleBackColor = true;
            CbOtro.CheckedChanged += CbOtro_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(238, 535);
            label5.Name = "label5";
            label5.Size = new Size(474, 40);
            label5.TabIndex = 1024;
            label5.Text = "HABITOS SICOBIOLÓGICOS";
            // 
            // tbExpliBio
            // 
            tbExpliBio.BackColor = SystemColors.ControlLight;
            tbExpliBio.Cursor = Cursors.IBeam;
            tbExpliBio.Enabled = false;
            tbExpliBio.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbExpliBio.Location = new Point(238, 470);
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
            CbBiopoli.Location = new Point(22, 473);
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
            TbExpliTrata.Location = new Point(238, 434);
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
            CbTrata.Location = new Point(22, 437);
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
            TbExpliCiru.Location = new Point(238, 398);
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
            CbCiru.Location = new Point(22, 401);
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
            TbExpliAlergAli.Location = new Point(238, 362);
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
            CbAlergiAli.Location = new Point(22, 365);
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
            TbExplAlergiaMed.Location = new Point(238, 326);
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
            CbAlegiaMedi.Location = new Point(22, 329);
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
            tbExpliEnfer.Location = new Point(238, 290);
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
            CbEnfermedad.Location = new Point(22, 293);
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
            label4.Location = new Point(194, 231);
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
            TbTele.PlaceholderText = "Telefono";
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
            PanelContrato.Controls.Add(lblNombFirma);
            PanelContrato.Controls.Add(label2);
            PanelContrato.Controls.Add(label1);
            PanelContrato.Location = new Point(3, 591);
            PanelContrato.Name = "PanelContrato";
            PanelContrato.Size = new Size(38, 70);
            PanelContrato.TabIndex = 1011;
            // 
            // lblNombFirma
            // 
            lblNombFirma.AutoSize = true;
            lblNombFirma.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombFirma.Location = new Point(434, 674);
            lblNombFirma.Name = "lblNombFirma";
            lblNombFirma.Size = new Size(65, 22);
            lblNombFirma.TabIndex = 10;
            lblNombFirma.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 289);
            label2.Name = "label2";
            label2.Size = new Size(866, 270);
            label2.TabIndex = 9;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(310, 10);
            label1.Name = "label1";
            label1.Size = new Size(311, 44);
            label1.TabIndex = 4;
            label1.Text = "EXAMEN FISICO";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(934, 172);
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
            Size = new Size(938, 942);
            Load += UcPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelFromulario.ResumeLayout(false);
            PanelFromulario.PerformLayout();
            PanelContrato.ResumeLayout(false);
            PanelContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbNombre;
        private TextBox tb;
        private ComboBox cbSexo;
        private TextBox tbCedula;
        private PictureBox pictureBox1;
        private Panel PanelFromulario;
        private Panel PanelContrato;
        private Label label1;
        private Label label2;
        private Label lblNombFirma;
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
        private CheckBox checkBox2;
        private CheckBox CbOtro;
        private Label label5;
        private TextBox TbOtros;
        private TextBox TxOcupa;
    }
}
