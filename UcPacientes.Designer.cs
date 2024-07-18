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
            MsPrisical.SuspendLayout();
            SuspendLayout();
            // 
            // MsPrisical
            // 
            MsPrisical.BackColor = Color.FromArgb(234, 242, 215);
            MsPrisical.Items.AddRange(new ToolStripItem[] { MsItemPaci });
            MsPrisical.Location = new Point(0, 0);
            MsPrisical.Name = "MsPrisical";
            MsPrisical.Size = new Size(1205, 24);
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
            lblDatosPerso.Location = new Point(382, 66);
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
            TbPrimNombre.Location = new Point(176, 165);
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
            tbSeguApe.Location = new Point(823, 165);
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
            tbPrimerApi.Location = new Point(607, 165);
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
            tbSeguNomb.Location = new Point(392, 165);
            tbSeguNomb.Margin = new Padding(5);
            tbSeguNomb.Name = "tbSeguNomb";
            tbSeguNomb.PlaceholderText = "Segundo nombre";
            tbSeguNomb.Size = new Size(206, 26);
            tbSeguNomb.TabIndex = 1;
            // 
            // mcFechaNaci
            // 
            mcFechaNaci.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcFechaNaci.Location = new Point(176, 201);
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
            tbEdad.Location = new Point(429, 200);
            tbEdad.Margin = new Padding(5);
            tbEdad.Name = "tbEdad";
            tbEdad.PlaceholderText = "Edad";
            tbEdad.Size = new Size(144, 26);
            tbEdad.TabIndex = 9;
            // 
            // tb
            // 
            tb.BackColor = SystemColors.ControlLightLight;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.Cursor = Cursors.IBeam;
            tb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb.Location = new Point(607, 237);
            tb.Margin = new Padding(5);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.PlaceholderText = "Direccion";
            tb.Size = new Size(422, 130);
            tb.TabIndex = 12;
            tb.TextChanged += tb_TextChanged;
            // 
            // tbTelef
            // 
            tbTelef.BackColor = SystemColors.ControlLightLight;
            tbTelef.BorderStyle = BorderStyle.FixedSingle;
            tbTelef.Cursor = Cursors.IBeam;
            tbTelef.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTelef.Location = new Point(607, 201);
            tbTelef.Margin = new Padding(5);
            tbTelef.Name = "tbTelef";
            tbTelef.PlaceholderText = "Telefono";
            tbTelef.Size = new Size(206, 26);
            tbTelef.TabIndex = 13;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "< SEXO >", "MASCULINO", "FEMENICNO", "OTROS" });
            cbSexo.Location = new Point(823, 203);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(206, 23);
            cbSexo.TabIndex = 14;
            // 
            // UcPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 222, 226);
            Controls.Add(cbSexo);
            Controls.Add(tbTelef);
            Controls.Add(tb);
            Controls.Add(tbEdad);
            Controls.Add(mcFechaNaci);
            Controls.Add(tbSeguNomb);
            Controls.Add(tbPrimerApi);
            Controls.Add(tbSeguApe);
            Controls.Add(TbPrimNombre);
            Controls.Add(lblDatosPerso);
            Controls.Add(MsPrisical);
            Name = "UcPacientes";
            Size = new Size(1205, 553);
            MsPrisical.ResumeLayout(false);
            MsPrisical.PerformLayout();
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
    }
}
