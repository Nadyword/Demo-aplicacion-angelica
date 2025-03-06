using System.Windows.Forms;

namespace HitoriaClinica.Pantallas
{
    partial class UcTratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTratamientos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            TsMPacientes = new ToolStripMenuItem();
            toolStripMenuItemAgregar = new ToolStripMenuItem();
            toolStripMenuItemBuscar = new ToolStripMenuItem();
            tratamientosToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            renombrarToolStripMenuItem = new ToolStripMenuItem();
            GvTratamientos = new DataGridView();
            TbAgreTrata = new TextBox();
            PbAgregar = new PictureBox();
            PbRecargar = new PictureBox();
            CbActivo = new DataGridViewCheckBoxColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvTratamientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbRecargar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Membrete;
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(934, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1012;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { TsMPacientes, tratamientosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(955, 24);
            menuStrip1.TabIndex = 1014;
            menuStrip1.Text = "menuStrip1";
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
            // GvTratamientos
            // 
            GvTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvTratamientos.Columns.AddRange(new DataGridViewColumn[] { CbActivo, BtnEliminar });
            GvTratamientos.Location = new Point(42, 415);
            GvTratamientos.Name = "GvTratamientos";
            GvTratamientos.Size = new Size(843, 406);
            GvTratamientos.TabIndex = 1015;
            GvTratamientos.CellContentClick += GvTratamientos_CellContentClick;
            // 
            // TbAgreTrata
            // 
            TbAgreTrata.BackColor = SystemColors.ControlLight;
            TbAgreTrata.Cursor = Cursors.IBeam;
            TbAgreTrata.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbAgreTrata.Location = new Point(300, 318);
            TbAgreTrata.Margin = new Padding(5);
            TbAgreTrata.Name = "TbAgreTrata";
            TbAgreTrata.PlaceholderText = "Nuevo tratamiento";
            TbAgreTrata.Size = new Size(310, 26);
            TbAgreTrata.TabIndex = 1016;
            // 
            // PbAgregar
            // 
            PbAgregar.BackColor = Color.Transparent;
            PbAgregar.Cursor = Cursors.Hand;
            PbAgregar.ErrorImage = (Image)resources.GetObject("PbAgregar.ErrorImage");
            PbAgregar.Image = Properties.Resources.agregar;
            PbAgregar.Location = new Point(618, 305);
            PbAgregar.Name = "PbAgregar";
            PbAgregar.Size = new Size(102, 49);
            PbAgregar.SizeMode = PictureBoxSizeMode.StretchImage;
            PbAgregar.TabIndex = 1020;
            PbAgregar.TabStop = false;
            PbAgregar.Click += PbAgregar_Click;
            // 
            // PbRecargar
            // 
            PbRecargar.BackColor = Color.Transparent;
            PbRecargar.Cursor = Cursors.Hand;
            PbRecargar.ErrorImage = Properties.Resources.recargar;
            PbRecargar.Image = Properties.Resources.recargar;
            PbRecargar.Location = new Point(772, 827);
            PbRecargar.Name = "PbRecargar";
            PbRecargar.Size = new Size(104, 98);
            PbRecargar.SizeMode = PictureBoxSizeMode.StretchImage;
            PbRecargar.TabIndex = 1021;
            PbRecargar.TabStop = false;
            PbRecargar.Click += PbRecargar_Click;
            // 
            // CbActivo
            // 
            CbActivo.DataPropertyName = "Activo";
            CbActivo.HeaderText = "Mostrar";
            CbActivo.Name = "CbActivo";
            // 
            // BtnEliminar
            // 
            BtnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            BtnEliminar.DefaultCellStyle = dataGridViewCellStyle1;
            BtnEliminar.HeaderText = "Borrar";
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Text = "Borrar";
            BtnEliminar.ToolTipText = "Borrar";
            BtnEliminar.UseColumnTextForButtonValue = true;
            BtnEliminar.Width = 75;
            // 
            // UcTratamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.fondo;
            Controls.Add(PbRecargar);
            Controls.Add(PbAgregar);
            Controls.Add(TbAgreTrata);
            Controls.Add(GvTratamientos);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(955, 1000);
            MinimumSize = new Size(955, 0);
            Name = "UcTratamientos";
            Size = new Size(955, 965);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GvTratamientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbRecargar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem TsMPacientes;
        public ToolStripMenuItem toolStripMenuItemAgregar;
        public ToolStripMenuItem toolStripMenuItemBuscar;
        private ToolStripMenuItem tratamientosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem renombrarToolStripMenuItem;
        public DataGridView GvTratamientos;
        public TextBox TbAgreTrata;
        public PictureBox PbAgregar;
        public PictureBox PbRecargar;
        private DataGridViewCheckBoxColumn CbActivo;
        private DataGridViewButtonColumn BtnEliminar;
    }
}
