using System.Windows.Forms;

namespace Demo_aplicacion_angelica_V1
{
    public partial class FromInicio : Form
    {
        public FromInicio()
        {
            InitializeComponent();

            UnProgramita miUserControl = new()
            {
                Dock = DockStyle.Fill 
            };

            this.Controls.Add(miUserControl);
        }

        private void MsItemPaciCrear_Click(object sender, EventArgs e)
        {

        }

        private void MsItemPaciSalir_Click(object sender, EventArgs e)
        {

        }

        private void FromInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
