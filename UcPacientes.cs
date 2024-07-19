using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_aplicacion_angelica_V1
{
    public partial class UcPacientes : UserControl
    {
        public UcPacientes()
        {
            InitializeComponent();
            mcFechaNaci.SetDate(new DateTime(1990, 01, 01));
            ShowPanels(1);
        }

        private void McFechaNaci_DateChanged(object sender, DateRangeEventArgs e)
        {
            TimeSpan edad = DateTime.Now - mcFechaNaci.SelectionStart;

            tbEdad.Text = Math.Floor(edad.TotalDays / 365) + " años";
        }

        private void CblHabitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblHabitos.SelectedItem != null)
            {
                if (cblHabitos.SelectedItem.ToString() == "OCUPACION")
                {
                    tbOcupacion.Enabled = true;
                }
                else
                {
                    tbOcupacion.Enabled = false;
                }
            }
        }

        private void UcPacientes_Load(object sender, EventArgs e)
        {

        }

        private void ShowPanels(int Panel)
        {
            switch (Panel)
            {
                case 1:
                    PanelFromulario.Visible = true;
                    PanelContrato.Visible = false;
                    break;
                case 2:
                    PanelFromulario.Visible = false;
                    PanelContrato.Visible = true;
                    break;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ShowPanels(2);
            lblNombFirma.Text = tbPrimerApi.Text.ToUpper() + " " + tbSeguApe.Text.ToUpper() 
                + " " + TbPrimNombre.Text.ToUpper() + " " + tbSeguNomb.Text.ToUpper()+ "\n" +
                "C.I: " + tbCedula.Text;
        }
    }
}
