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
            MsPrisical = new MenuStrip();
            MsItemPaci = new ToolStripMenuItem();
            MsItemPaciCrear = new ToolStripMenuItem();
            MsItemPaciModif = new ToolStripMenuItem();
            MsItemPaciBusca = new ToolStripMenuItem();
            MsItemPaciElimi = new ToolStripMenuItem();
            MsItemPaciSalir = new ToolStripMenuItem();
            lblDatosPerso = new Label();
            TbPrimNombre = new TextBox();
            tbSeguApe = new TextBox();
            tbPrimerApi = new TextBox();
            tbSeguNomb = new TextBox();
            mcFechaNaci = new MonthCalendar();
            tbEdad = new TextBox();
            tb = new TextBox();
            tbTelef = new TextBox();
            cbSexo = new ComboBox();
            tbFacial = new TextBox();
            Ambas = new TextBox();
            tbCorpo = new TextBox();
            lblAntecendentes = new Label();
            tbEnfermedad = new TextBox();
            tbAlergia = new TextBox();
            tbCirugia = new TextBox();
            tbTratamientosAn = new TextBox();
            lblHabitos = new Label();
            cblHabitos = new CheckedListBox();
            tbOcupacion = new TextBox();
            tbCedula = new TextBox();
            pictureBox1 = new PictureBox();
            PanelFromulario = new Panel();
            PanelContrato = new Panel();
            lblNombFirma = new Label();
            label2 = new Label();
            tbExamenFisi = new TextBox();
            label1 = new Label();
            MsPrisical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelFromulario.SuspendLayout();
            PanelContrato.SuspendLayout();
            SuspendLayout();
            // 
            // MsPrisical
            // 
            MsPrisical.BackColor = Color.FromArgb(234, 242, 215);
            MsPrisical.Items.AddRange(new ToolStripItem[] { MsItemPaci });
            MsPrisical.Location = new Point(0, 0);
            MsPrisical.Name = "MsPrisical";
            MsPrisical.Size = new Size(964, 24);
            MsPrisical.TabIndex = 2;
            MsPrisical.Text = "MsPrincial";
            // 
            // MsItemPaci
            // 
            MsItemPaci.DropDownItems.AddRange(new ToolStripItem[] { MsItemPaciCrear, MsItemPaciModif, MsItemPaciBusca, MsItemPaciElimi, MsItemPaciSalir });
            MsItemPaci.Name = "MsItemPaci";
            MsItemPaci.Size = new Size(69, 20);
            MsItemPaci.Text = "Pacientes";
            // 
            // MsItemPaciCrear
            // 
            MsItemPaciCrear.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciCrear.Image = (Image)resources.GetObject("MsItemPaciCrear.Image");
            MsItemPaciCrear.Name = "MsItemPaciCrear";
            MsItemPaciCrear.ShortcutKeys = Keys.Control | Keys.N;
            MsItemPaciCrear.Size = new Size(170, 22);
            MsItemPaciCrear.Text = "Crear";
            // 
            // MsItemPaciModif
            // 
            MsItemPaciModif.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciModif.Image = (Image)resources.GetObject("MsItemPaciModif.Image");
            MsItemPaciModif.Name = "MsItemPaciModif";
            MsItemPaciModif.ShortcutKeys = Keys.Control | Keys.M;
            MsItemPaciModif.Size = new Size(170, 22);
            MsItemPaciModif.Text = "Modificar";
            // 
            // MsItemPaciBusca
            // 
            MsItemPaciBusca.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciBusca.Image = (Image)resources.GetObject("MsItemPaciBusca.Image");
            MsItemPaciBusca.Name = "MsItemPaciBusca";
            MsItemPaciBusca.ShortcutKeys = Keys.Control | Keys.B;
            MsItemPaciBusca.Size = new Size(170, 22);
            MsItemPaciBusca.Text = "Buscar";
            // 
            // MsItemPaciElimi
            // 
            MsItemPaciElimi.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciElimi.Image = (Image)resources.GetObject("MsItemPaciElimi.Image");
            MsItemPaciElimi.Name = "MsItemPaciElimi";
            MsItemPaciElimi.ShortcutKeys = Keys.Control | Keys.E;
            MsItemPaciElimi.Size = new Size(170, 22);
            MsItemPaciElimi.Text = "Eliminar";
            // 
            // MsItemPaciSalir
            // 
            MsItemPaciSalir.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciSalir.Image = (Image)resources.GetObject("MsItemPaciSalir.Image");
            MsItemPaciSalir.Name = "MsItemPaciSalir";
            MsItemPaciSalir.ShortcutKeys = Keys.Control | Keys.S;
            MsItemPaciSalir.Size = new Size(170, 22);
            MsItemPaciSalir.Text = "Salir";
            // 
            // lblDatosPerso
            // 
            lblDatosPerso.AutoSize = true;
            lblDatosPerso.FlatStyle = FlatStyle.Flat;
            lblDatosPerso.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPerso.ForeColor = Color.Black;
            lblDatosPerso.Location = new Point(218, 10);
            lblDatosPerso.Name = "lblDatosPerso";
            lblDatosPerso.Size = new Size(414, 44);
            lblDatosPerso.TabIndex = 3;
            lblDatosPerso.Text = "DATOS PERSONALES";
            // 
            // TbPrimNombre
            // 
            TbPrimNombre.BackColor = SystemColors.ControlLightLight;
            TbPrimNombre.BorderStyle = BorderStyle.FixedSingle;
            TbPrimNombre.Cursor = Cursors.IBeam;
            TbPrimNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbPrimNombre.Location = new Point(12, 133);
            TbPrimNombre.Margin = new Padding(5);
            TbPrimNombre.Name = "TbPrimNombre";
            TbPrimNombre.PlaceholderText = "Primer nombre";
            TbPrimNombre.Size = new Size(206, 26);
            TbPrimNombre.TabIndex = 0;
            // 
            // tbSeguApe
            // 
            tbSeguApe.BackColor = SystemColors.ControlLightLight;
            tbSeguApe.BorderStyle = BorderStyle.FixedSingle;
            tbSeguApe.Cursor = Cursors.IBeam;
            tbSeguApe.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSeguApe.Location = new Point(659, 133);
            tbSeguApe.Margin = new Padding(5);
            tbSeguApe.Name = "tbSeguApe";
            tbSeguApe.PlaceholderText = "Segundo apellido";
            tbSeguApe.Size = new Size(206, 26);
            tbSeguApe.TabIndex = 3;
            // 
            // tbPrimerApi
            // 
            tbPrimerApi.BackColor = SystemColors.ControlLightLight;
            tbPrimerApi.BorderStyle = BorderStyle.FixedSingle;
            tbPrimerApi.Cursor = Cursors.IBeam;
            tbPrimerApi.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrimerApi.Location = new Point(443, 133);
            tbPrimerApi.Margin = new Padding(5);
            tbPrimerApi.Name = "tbPrimerApi";
            tbPrimerApi.PlaceholderText = "Primer apellido";
            tbPrimerApi.Size = new Size(206, 26);
            tbPrimerApi.TabIndex = 2;
            // 
            // tbSeguNomb
            // 
            tbSeguNomb.BackColor = SystemColors.ControlLightLight;
            tbSeguNomb.BorderStyle = BorderStyle.FixedSingle;
            tbSeguNomb.Cursor = Cursors.IBeam;
            tbSeguNomb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSeguNomb.Location = new Point(228, 133);
            tbSeguNomb.Margin = new Padding(5);
            tbSeguNomb.Name = "tbSeguNomb";
            tbSeguNomb.PlaceholderText = "Segundo nombre";
            tbSeguNomb.Size = new Size(206, 26);
            tbSeguNomb.TabIndex = 1;
            // 
            // mcFechaNaci
            // 
            mcFechaNaci.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcFechaNaci.Location = new Point(12, 169);
            mcFechaNaci.MaxDate = new DateTime(3500, 12, 31, 0, 0, 0, 0);
            mcFechaNaci.Name = "mcFechaNaci";
            mcFechaNaci.TabIndex = 7;
            mcFechaNaci.DateChanged += McFechaNaci_DateChanged;
            // 
            // tbEdad
            // 
            tbEdad.BackColor = SystemColors.ControlLightLight;
            tbEdad.BorderStyle = BorderStyle.FixedSingle;
            tbEdad.Cursor = Cursors.IBeam;
            tbEdad.Enabled = false;
            tbEdad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEdad.Location = new Point(265, 168);
            tbEdad.Margin = new Padding(5);
            tbEdad.Name = "tbEdad";
            tbEdad.PlaceholderText = "Edad";
            tbEdad.Size = new Size(144, 26);
            tbEdad.TabIndex = 999;
            // 
            // tb
            // 
            tb.BackColor = SystemColors.ControlLightLight;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Cursor = Cursors.IBeam;
            tb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb.Location = new Point(265, 205);
            tb.Margin = new Padding(5);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.PlaceholderText = "Direccion";
            tb.Size = new Size(600, 126);
            tb.TabIndex = 6;
            // 
            // tbTelef
            // 
            tbTelef.BackColor = SystemColors.ControlLightLight;
            tbTelef.BorderStyle = BorderStyle.FixedSingle;
            tbTelef.Cursor = Cursors.IBeam;
            tbTelef.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTelef.Location = new Point(443, 169);
            tbTelef.Margin = new Padding(5);
            tbTelef.Name = "tbTelef";
            tbTelef.PlaceholderText = "Telefono";
            tbTelef.Size = new Size(206, 26);
            tbTelef.TabIndex = 4;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "< SEXO >", "MASCULINO", "FEMENICNO", "OTROS" });
            cbSexo.Location = new Point(659, 171);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(206, 23);
            cbSexo.TabIndex = 5;
            // 
            // tbFacial
            // 
            tbFacial.BackColor = SystemColors.ControlLightLight;
            tbFacial.BorderStyle = BorderStyle.FixedSingle;
            tbFacial.Cursor = Cursors.IBeam;
            tbFacial.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFacial.Location = new Point(12, 341);
            tbFacial.Margin = new Padding(5);
            tbFacial.Multiline = true;
            tbFacial.Name = "tbFacial";
            tbFacial.PlaceholderText = "Facial";
            tbFacial.Size = new Size(853, 67);
            tbFacial.TabIndex = 7;
            // 
            // Ambas
            // 
            Ambas.BackColor = SystemColors.ControlLightLight;
            Ambas.BorderStyle = BorderStyle.FixedSingle;
            Ambas.Cursor = Cursors.IBeam;
            Ambas.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ambas.Location = new Point(12, 495);
            Ambas.Margin = new Padding(5);
            Ambas.Multiline = true;
            Ambas.Name = "Ambas";
            Ambas.PlaceholderText = "Ambas";
            Ambas.Size = new Size(853, 67);
            Ambas.TabIndex = 9;
            // 
            // tbCorpo
            // 
            tbCorpo.BackColor = SystemColors.ControlLightLight;
            tbCorpo.BorderStyle = BorderStyle.FixedSingle;
            tbCorpo.Cursor = Cursors.IBeam;
            tbCorpo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCorpo.Location = new Point(12, 418);
            tbCorpo.Margin = new Padding(5);
            tbCorpo.Multiline = true;
            tbCorpo.Name = "tbCorpo";
            tbCorpo.PlaceholderText = "Corporal";
            tbCorpo.Size = new Size(853, 67);
            tbCorpo.TabIndex = 8;
            // 
            // lblAntecendentes
            // 
            lblAntecendentes.AutoSize = true;
            lblAntecendentes.FlatStyle = FlatStyle.Flat;
            lblAntecendentes.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAntecendentes.ForeColor = Color.Black;
            lblAntecendentes.Location = new Point(141, 580);
            lblAntecendentes.Name = "lblAntecendentes";
            lblAntecendentes.Size = new Size(593, 44);
            lblAntecendentes.TabIndex = 1000;
            lblAntecendentes.Text = "ANTECEDENTES PERSONALES";
            // 
            // tbEnfermedad
            // 
            tbEnfermedad.BackColor = SystemColors.ControlLightLight;
            tbEnfermedad.BorderStyle = BorderStyle.FixedSingle;
            tbEnfermedad.Cursor = Cursors.IBeam;
            tbEnfermedad.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEnfermedad.Location = new Point(12, 629);
            tbEnfermedad.Margin = new Padding(5);
            tbEnfermedad.Multiline = true;
            tbEnfermedad.Name = "tbEnfermedad";
            tbEnfermedad.PlaceholderText = "Enfermedad cronica";
            tbEnfermedad.Size = new Size(853, 67);
            tbEnfermedad.TabIndex = 10;
            // 
            // tbAlergia
            // 
            tbAlergia.BackColor = SystemColors.ControlLightLight;
            tbAlergia.BorderStyle = BorderStyle.FixedSingle;
            tbAlergia.Cursor = Cursors.IBeam;
            tbAlergia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlergia.Location = new Point(12, 706);
            tbAlergia.Margin = new Padding(5);
            tbAlergia.Multiline = true;
            tbAlergia.Name = "tbAlergia";
            tbAlergia.PlaceholderText = "Alergia medicamento o alimentos";
            tbAlergia.Size = new Size(853, 67);
            tbAlergia.TabIndex = 11;
            // 
            // tbCirugia
            // 
            tbCirugia.BackColor = SystemColors.ControlLightLight;
            tbCirugia.BorderStyle = BorderStyle.FixedSingle;
            tbCirugia.Cursor = Cursors.IBeam;
            tbCirugia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCirugia.Location = new Point(12, 783);
            tbCirugia.Margin = new Padding(5);
            tbCirugia.Multiline = true;
            tbCirugia.Name = "tbCirugia";
            tbCirugia.PlaceholderText = "Cirugias";
            tbCirugia.Size = new Size(853, 67);
            tbCirugia.TabIndex = 12;
            // 
            // tbTratamientosAn
            // 
            tbTratamientosAn.BackColor = SystemColors.ControlLightLight;
            tbTratamientosAn.BorderStyle = BorderStyle.FixedSingle;
            tbTratamientosAn.Cursor = Cursors.IBeam;
            tbTratamientosAn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTratamientosAn.Location = new Point(12, 860);
            tbTratamientosAn.Margin = new Padding(5);
            tbTratamientosAn.Multiline = true;
            tbTratamientosAn.Name = "tbTratamientosAn";
            tbTratamientosAn.PlaceholderText = "Tratamientos anteriores";
            tbTratamientosAn.Size = new Size(853, 67);
            tbTratamientosAn.TabIndex = 13;
            // 
            // lblHabitos
            // 
            lblHabitos.AutoSize = true;
            lblHabitos.FlatStyle = FlatStyle.Flat;
            lblHabitos.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHabitos.ForeColor = Color.Black;
            lblHabitos.Location = new Point(151, 947);
            lblHabitos.Name = "lblHabitos";
            lblHabitos.Size = new Size(546, 44);
            lblHabitos.TabIndex = 1005;
            lblHabitos.Text = "HABITOS PSICOBIOLOGICOS";
            // 
            // cblHabitos
            // 
            cblHabitos.FormattingEnabled = true;
            cblHabitos.Items.AddRange(new object[] { "HÁBITO TABAQUICO", "ACTIVIDAD DEPORTIVA", "ALCOHOL", "OCUPACION", "ESTRES" });
            cblHabitos.Location = new Point(5, 1009);
            cblHabitos.Name = "cblHabitos";
            cblHabitos.Size = new Size(167, 94);
            cblHabitos.TabIndex = 1006;
            cblHabitos.SelectedIndexChanged += CblHabitos_SelectedIndexChanged;
            // 
            // tbOcupacion
            // 
            tbOcupacion.BackColor = SystemColors.ControlLightLight;
            tbOcupacion.BorderStyle = BorderStyle.FixedSingle;
            tbOcupacion.Cursor = Cursors.IBeam;
            tbOcupacion.Enabled = false;
            tbOcupacion.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOcupacion.Location = new Point(198, 1055);
            tbOcupacion.Margin = new Padding(5);
            tbOcupacion.Name = "tbOcupacion";
            tbOcupacion.PlaceholderText = "Ocupacion";
            tbOcupacion.Size = new Size(367, 26);
            tbOcupacion.TabIndex = 1007;
            // 
            // tbCedula
            // 
            tbCedula.BackColor = SystemColors.ControlLightLight;
            tbCedula.BorderStyle = BorderStyle.FixedSingle;
            tbCedula.Cursor = Cursors.IBeam;
            tbCedula.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCedula.Location = new Point(308, 82);
            tbCedula.Margin = new Padding(5);
            tbCedula.Name = "tbCedula";
            tbCedula.PlaceholderText = "Cedula";
            tbCedula.Size = new Size(206, 26);
            tbCedula.TabIndex = 1008;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(762, 986);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 126);
            pictureBox1.TabIndex = 1009;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // PanelFromulario
            // 
            PanelFromulario.Controls.Add(lblDatosPerso);
            PanelFromulario.Controls.Add(pictureBox1);
            PanelFromulario.Controls.Add(TbPrimNombre);
            PanelFromulario.Controls.Add(tbOcupacion);
            PanelFromulario.Controls.Add(tbCedula);
            PanelFromulario.Controls.Add(cblHabitos);
            PanelFromulario.Controls.Add(tbSeguApe);
            PanelFromulario.Controls.Add(lblHabitos);
            PanelFromulario.Controls.Add(tbPrimerApi);
            PanelFromulario.Controls.Add(tbTratamientosAn);
            PanelFromulario.Controls.Add(tbSeguNomb);
            PanelFromulario.Controls.Add(tbCirugia);
            PanelFromulario.Controls.Add(mcFechaNaci);
            PanelFromulario.Controls.Add(tbEdad);
            PanelFromulario.Controls.Add(tb);
            PanelFromulario.Controls.Add(tbAlergia);
            PanelFromulario.Controls.Add(tbTelef);
            PanelFromulario.Controls.Add(tbEnfermedad);
            PanelFromulario.Controls.Add(cbSexo);
            PanelFromulario.Controls.Add(lblAntecendentes);
            PanelFromulario.Controls.Add(tbFacial);
            PanelFromulario.Controls.Add(tbCorpo);
            PanelFromulario.Controls.Add(Ambas);
            PanelFromulario.Location = new Point(27, 27);
            PanelFromulario.Name = "PanelFromulario";
            PanelFromulario.Size = new Size(906, 1139);
            PanelFromulario.TabIndex = 1010;
            // 
            // PanelContrato
            // 
            PanelContrato.Controls.Add(lblNombFirma);
            PanelContrato.Controls.Add(label2);
            PanelContrato.Controls.Add(tbExamenFisi);
            PanelContrato.Controls.Add(label1);
            PanelContrato.Location = new Point(24, 27);
            PanelContrato.Name = "PanelContrato";
            PanelContrato.Size = new Size(906, 713);
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
            // tbExamenFisi
            // 
            tbExamenFisi.BackColor = SystemColors.ControlLightLight;
            tbExamenFisi.BorderStyle = BorderStyle.FixedSingle;
            tbExamenFisi.Cursor = Cursors.IBeam;
            tbExamenFisi.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbExamenFisi.Location = new Point(26, 72);
            tbExamenFisi.Margin = new Padding(5);
            tbExamenFisi.Multiline = true;
            tbExamenFisi.Name = "tbExamenFisi";
            tbExamenFisi.Size = new Size(853, 201);
            tbExamenFisi.TabIndex = 8;
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
            // UcPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(179, 222, 226);
            Controls.Add(PanelContrato);
            Controls.Add(PanelFromulario);
            Controls.Add(MsPrisical);
            Name = "UcPacientes";
            Size = new Size(964, 1176);
            Load += UcPacientes_Load;
            MsPrisical.ResumeLayout(false);
            MsPrisical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelFromulario.ResumeLayout(false);
            PanelFromulario.PerformLayout();
            PanelContrato.ResumeLayout(false);
            PanelContrato.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MsPrisical;
        private ToolStripMenuItem MsItemPaci;
        private ToolStripMenuItem MsItemPaciCrear;
        private ToolStripMenuItem MsItemPaciModif;
        private ToolStripMenuItem MsItemPaciBusca;
        private ToolStripMenuItem MsItemPaciElimi;
        private ToolStripMenuItem MsItemPaciSalir;
        private Label lblDatosPerso;
        private TextBox TbPrimNombre;
        private TextBox tbSeguApe;
        private TextBox tbPrimerApi;
        private TextBox tbSeguNomb;
        private MonthCalendar mcFechaNaci;
        private TextBox tbEdad;
        private TextBox tb;
        private TextBox tbTelef;
        private ComboBox cbSexo;
        private TextBox tbFacial;
        private TextBox Ambas;
        private TextBox tbCorpo;
        private Label lblAntecendentes;
        private TextBox tbEnfermedad;
        private TextBox tbAlergia;
        private TextBox tbCirugia;
        private TextBox tbTratamientosAn;
        private Label lblHabitos;
        private CheckedListBox cblHabitos;
        private TextBox tbOcupacion;
        private TextBox tbCedula;
        private PictureBox pictureBox1;
        private Panel PanelFromulario;
        private Panel PanelContrato;
        private Label label1;
        private TextBox tbExamenFisi;
        private Label label2;
        private Label lblNombFirma;
    }
}
