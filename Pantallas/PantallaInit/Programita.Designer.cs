namespace HitoriaClinica
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
            menuStrip1 = new MenuStrip();
            TsMPacientes = new ToolStripMenuItem();
            toolStripMenuItemAgregar = new ToolStripMenuItem();
            toolStripMenuItemBuscar = new ToolStripMenuItem();
            tratamientosToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            renombrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            SmiAgregarPaci = new ToolStripMenuItem();
            SmiBuscar = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsMPacientes, tratamientosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 24);
            menuStrip1.TabIndex = 1014;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // TsMPacientes
            // 
            TsMPacientes.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAgregar, toolStripMenuItemBuscar });
            TsMPacientes.ForeColor = SystemColors.ActiveCaptionText;
            TsMPacientes.Name = "TsMPacientes";
            TsMPacientes.Size = new Size(69, 20);
            TsMPacientes.Text = "Pacientes";
            // 
            // toolStripMenuItemAgregar
            // 
            toolStripMenuItemAgregar.Image = (Image)resources.GetObject("toolStripMenuItemAgregar.Image");
            toolStripMenuItemAgregar.Name = "toolStripMenuItemAgregar";
            toolStripMenuItemAgregar.Size = new Size(116, 22);
            toolStripMenuItemAgregar.Text = "Agregar";
            // 
            // toolStripMenuItemBuscar
            // 
            toolStripMenuItemBuscar.Image = (Image)resources.GetObject("toolStripMenuItemBuscar.Image");
            toolStripMenuItemBuscar.Name = "toolStripMenuItemBuscar";
            toolStripMenuItemBuscar.Size = new Size(116, 22);
            toolStripMenuItemBuscar.Text = "Buscar";
            // 
            // tratamientosToolStripMenuItem
            // 
            tratamientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, renombrarToolStripMenuItem });
            tratamientosToolStripMenuItem.Name = "tratamientosToolStripMenuItem";
            tratamientosToolStripMenuItem.Size = new Size(88, 20);
            tratamientosToolStripMenuItem.Text = "Tratamientos";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(133, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // renombrarToolStripMenuItem
            // 
            renombrarToolStripMenuItem.Name = "renombrarToolStripMenuItem";
            renombrarToolStripMenuItem.Size = new Size(133, 22);
            renombrarToolStripMenuItem.Text = "Renombrar";
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ActiveCaption;
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(934, 24);
            menuStrip2.TabIndex = 1015;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { SmiAgregarPaci, SmiBuscar });
            toolStripMenuItem1.ForeColor = SystemColors.ActiveCaptionText;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(69, 20);
            toolStripMenuItem1.Text = "Pacientes";
            // 
            // SmiAgregarPaci
            // 
            SmiAgregarPaci.Image = (Image)resources.GetObject("SmiAgregarPaci.Image");
            SmiAgregarPaci.Name = "SmiAgregarPaci";
            SmiAgregarPaci.Size = new Size(180, 22);
            SmiAgregarPaci.Text = "Agregar";
            SmiAgregarPaci.Click += SmiAgregar_Click;
            // 
            // SmiBuscar
            // 
            SmiBuscar.Image = (Image)resources.GetObject("SmiBuscar.Image");
            SmiBuscar.Name = "SmiBuscar";
            SmiBuscar.Size = new Size(180, 22);
            SmiBuscar.Text = "Buscar";
            SmiBuscar.Click += SmiBuscar_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(88, 20);
            toolStripMenuItem4.Text = "Tratamientos";
            toolStripMenuItem4.Click += SmiAgregarTrata_Click;
            // 
            // FromInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 999);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximumSize = new Size(950, 1038);
            MinimumSize = new Size(950, 1038);
            Name = "FromInicio";
            Text = "Historial clínico Dra. Angélica Signorino";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        public ToolStripMenuItem TsMPacientes;
        public ToolStripMenuItem toolStripMenuItemAgregar;
        public ToolStripMenuItem toolStripMenuItemBuscar;
        private ToolStripMenuItem tratamientosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem renombrarToolStripMenuItem;
        public MenuStrip menuStrip2;
        public ToolStripMenuItem toolStripMenuItem1;
        public ToolStripMenuItem SmiAgregarPaci;
        public ToolStripMenuItem SmiBuscar;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}
