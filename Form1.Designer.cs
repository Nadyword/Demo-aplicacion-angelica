namespace Demo_aplicacion_angelica_V1
{
    partial class FromInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromInicio));
            MsPrisical = new MenuStrip();
            MsItemPaci = new ToolStripMenuItem();
            MsItemPaciCrear = new ToolStripMenuItem();
            MsItemPaciModif = new ToolStripMenuItem();
            MsItemPaciBusca = new ToolStripMenuItem();
            MsItemPaciElimi = new ToolStripMenuItem();
            MsPrisical.SuspendLayout();
            SuspendLayout();
            // 
            // MsPrisical
            // 
            MsPrisical.Items.AddRange(new ToolStripItem[] { MsItemPaci });
            MsPrisical.Location = new Point(0, 0);
            MsPrisical.Name = "MsPrisical";
            MsPrisical.Size = new Size(800, 24);
            MsPrisical.TabIndex = 0;
            MsPrisical.Text = "menuStrip1";
            // 
            // MsItemPaci
            // 
            MsItemPaci.DropDownItems.AddRange(new ToolStripItem[] { MsItemPaciCrear, MsItemPaciModif, MsItemPaciBusca, MsItemPaciElimi });
            MsItemPaci.Name = "MsItemPaci";
            MsItemPaci.Size = new Size(69, 20);
            MsItemPaci.Text = "Pacientes";
            MsItemPaci.Click += toolStripMenuItem1_Click;
            // 
            // MsItemPaciCrear
            // 
            MsItemPaciCrear.Name = "MsItemPaciCrear";
            MsItemPaciCrear.Size = new Size(180, 22);
            MsItemPaciCrear.Text = "Crear";
            MsItemPaciCrear.Click += toolStripMenuItem2_Click;
            // 
            // MsItemPaciModif
            // 
            MsItemPaciModif.Name = "MsItemPaciModif";
            MsItemPaciModif.Size = new Size(180, 22);
            MsItemPaciModif.Text = "Modificar";
            // 
            // MsItemPaciBusca
            // 
            MsItemPaciBusca.Name = "MsItemPaciBusca";
            MsItemPaciBusca.Size = new Size(180, 22);
            MsItemPaciBusca.Text = "Buscar";
            // 
            // MsItemPaciElimi
            // 
            MsItemPaciElimi.Name = "MsItemPaciElimi";
            MsItemPaciElimi.Size = new Size(180, 22);
            MsItemPaciElimi.Text = "Eliminar";
            // 
            // FromInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MsPrisical);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MsPrisical;
            Name = "FromInicio";
            Text = "Un programita";
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
    }
}
