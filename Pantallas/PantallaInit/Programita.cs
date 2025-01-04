using System.Windows.Forms;

namespace HitoriaClinica
{
    public partial class FromInicio : Form
    {
        public FromInicio()
        {
            InitializeComponent();

            UcPacientes miUserControl = new()
            {
                Dock = DockStyle.Fill 
            };

            this.Controls.Add(miUserControl);
        }
    }
}
