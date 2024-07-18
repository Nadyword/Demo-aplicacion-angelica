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
        }

        private void McFechaNaci_DateChanged(object sender, DateRangeEventArgs e)
        {
            TimeSpan edad = DateTime.Now - mcFechaNaci.SelectionStart;

            tbEdad.Text = Math.Floor(edad.TotalDays / 365) + " años";
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
