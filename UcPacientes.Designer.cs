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
            MsPrisical.SuspendLayout();
            SuspendLayout();
            // 
            // MsPrisical
            // 
            MsPrisical.BackColor = Color.FromArgb(234, 242, 215);
            MsPrisical.Items.AddRange(new ToolStripItem[] { MsItemPaci });
            MsPrisical.Location = new Point(0, 0);
            MsPrisical.Name = "MsPrisical";
            MsPrisical.Size = new Size(1158, 24);
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
            MsItemPaciCrear.Size = new Size(180, 22);
            MsItemPaciCrear.Text = "Crear";
            // 
            // MsItemPaciModif
            // 
            MsItemPaciModif.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciModif.Image = (Image)resources.GetObject("MsItemPaciModif.Image");
            MsItemPaciModif.Name = "MsItemPaciModif";
            MsItemPaciModif.ShortcutKeys = Keys.Control | Keys.M;
            MsItemPaciModif.Size = new Size(180, 22);
            MsItemPaciModif.Text = "Modificar";
            // 
            // MsItemPaciBusca
            // 
            MsItemPaciBusca.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciBusca.Image = (Image)resources.GetObject("MsItemPaciBusca.Image");
            MsItemPaciBusca.Name = "MsItemPaciBusca";
            MsItemPaciBusca.ShortcutKeys = Keys.Control | Keys.B;
            MsItemPaciBusca.Size = new Size(180, 22);
            MsItemPaciBusca.Text = "Buscar";
            // 
            // MsItemPaciElimi
            // 
            MsItemPaciElimi.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciElimi.Image = (Image)resources.GetObject("MsItemPaciElimi.Image");
            MsItemPaciElimi.Name = "MsItemPaciElimi";
            MsItemPaciElimi.ShortcutKeys = Keys.Control | Keys.E;
            MsItemPaciElimi.Size = new Size(180, 22);
            MsItemPaciElimi.Text = "Eliminar";
            // 
            // MsItemPaciSalir
            // 
            MsItemPaciSalir.BackColor = Color.FromArgb(234, 242, 215);
            MsItemPaciSalir.Image = (Image)resources.GetObject("MsItemPaciSalir.Image");
            MsItemPaciSalir.Name = "MsItemPaciSalir";
            MsItemPaciSalir.ShortcutKeys = Keys.Control | Keys.S;
            MsItemPaciSalir.Size = new Size(180, 22);
            MsItemPaciSalir.Text = "Salir";
            // 
            // UcPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 222, 226);
            Controls.Add(MsPrisical);
            Name = "UcPacientes";
            Size = new Size(1158, 553);
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
    }
}
