using HitoriaClinica.Pantallas;

namespace HitoriaClinica
{
    public partial class FromInicio : Form
    {
        private readonly UcPacientes ucPacientes;
        private readonly UcTratamientos ucTratamientos;

        public FromInicio()
        {
            InitializeComponent();

            ucPacientes = new UcPacientes
            {
                Dock = DockStyle.Fill
            };

            ucTratamientos = new UcTratamientos
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(ucTratamientos);
            this.Controls.Add(ucPacientes);
            SmiAgregar_Click(null, null);
        }

        private void SmiAgregar_Click(object? sender, EventArgs? e)
        {
            ucPacientes.BtnAgregar();
            ucTratamientos.Visible = false;
        }

        private void SmiAgregarTrata_Click(object sender, EventArgs e)
        {
            ucPacientes.Visible = false;
            ucTratamientos.Visible = true;
        }

        private void SmiBuscar_Click(object sender, EventArgs e)
        {
            ucPacientes.BtnBuscar();
        }
    }
}
