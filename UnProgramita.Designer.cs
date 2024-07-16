namespace Demo_aplicacion_angelica_V1
{
    partial class UnProgramita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnProgramita));
            MsPrisical = new MenuStrip();
            MsItemPaci = new ToolStripMenuItem();
            MsItemPaciCrear = new ToolStripMenuItem();
            MsItemPaciModif = new ToolStripMenuItem();
            MsItemPaciBusca = new ToolStripMenuItem();
            MsItemPaciElimi = new ToolStripMenuItem();
            MsItemPaciSalir = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MsPrisical.SuspendLayout();
            SuspendLayout();
            // 
            // MsPrisical
            // 
            MsPrisical.Items.AddRange(new ToolStripItem[] { MsItemPaci });
            MsPrisical.Location = new Point(0, 0);
            MsPrisical.Name = "MsPrisical";
            MsPrisical.Size = new Size(1067, 24);
            MsPrisical.TabIndex = 1;
            MsPrisical.Text = "MsPrincial";
            // 
            // MsItemPaci
            // 
            MsItemPaci.DropDownItems.AddRange(new ToolStripItem[] { MsItemPaciCrear, MsItemPaciModif, MsItemPaciBusca, MsItemPaciElimi, toolStripSeparator1, MsItemPaciSalir });
            MsItemPaci.Name = "MsItemPaci";
            MsItemPaci.Size = new Size(69, 20);
            MsItemPaci.Text = "Pacientes";
            // 
            // MsItemPaciCrear
            // 
            MsItemPaciCrear.Image = (Image)resources.GetObject("MsItemPaciCrear.Image");
            MsItemPaciCrear.Name = "MsItemPaciCrear";
            MsItemPaciCrear.ShortcutKeys = Keys.Control | Keys.N;
            MsItemPaciCrear.Size = new Size(180, 22);
            MsItemPaciCrear.Text = "Crear";
            // 
            // MsItemPaciModif
            // 
            MsItemPaciModif.Image = (Image)resources.GetObject("MsItemPaciModif.Image");
            MsItemPaciModif.Name = "MsItemPaciModif";
            MsItemPaciModif.ShortcutKeys = Keys.Control | Keys.M;
            MsItemPaciModif.Size = new Size(180, 22);
            MsItemPaciModif.Text = "Modificar";
            // 
            // MsItemPaciBusca
            // 
            MsItemPaciBusca.Image = (Image)resources.GetObject("MsItemPaciBusca.Image");
            MsItemPaciBusca.Name = "MsItemPaciBusca";
            MsItemPaciBusca.ShortcutKeys = Keys.Control | Keys.B;
            MsItemPaciBusca.Size = new Size(180, 22);
            MsItemPaciBusca.Text = "Buscar";
            // 
            // MsItemPaciElimi
            // 
            MsItemPaciElimi.Image = (Image)resources.GetObject("MsItemPaciElimi.Image");
            MsItemPaciElimi.Name = "MsItemPaciElimi";
            MsItemPaciElimi.ShortcutKeys = Keys.Control | Keys.E;
            MsItemPaciElimi.Size = new Size(180, 22);
            MsItemPaciElimi.Text = "Eliminar";
            // 
            // MsItemPaciSalir
            // 
            MsItemPaciSalir.Image = (Image)resources.GetObject("MsItemPaciSalir.Image");
            MsItemPaciSalir.Name = "MsItemPaciSalir";
            MsItemPaciSalir.ShortcutKeys = Keys.Control | Keys.S;
            MsItemPaciSalir.Size = new Size(180, 22);
            MsItemPaciSalir.Text = "Salir";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // UnProgramita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MsPrisical);
            Name = "UnProgramita";
            Size = new Size(1067, 560);
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
        private ToolStripSeparator toolStripSeparator1;
    }
}
