using HitoriaClinica.DataBase;
using HitoriaClinica.Pantallas.Tratamientos.Logic;

namespace HitoriaClinica.Pantallas;

public partial class UcTratamientos : UserControl
{
    public UcTratamientos()
    {
        InitializeComponent();
        PreloadData();
    }

    #region PreloadData

    public void PreloadData()
    {
        Utilidades.CargarComboTratamientos(this);
        GvTratamientos.Columns[0].Visible = false;
        GvTratamientos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        GvTratamientos.Rows[0].ReadOnly = true;
    }

    #endregion

    private void PbAgregar_Click(object sender, EventArgs e)
    {
        Insert.InsertTratamientoCombo(TbAgreTrata.Text);
        TbAgreTrata.Text = "";
        Utilidades.CargarComboTratamientos(this);
    }

    private void PbRecargar_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in GvTratamientos.Rows)
        {
            Updates.UpdateTratamientoCombo(row.Cells[2].FormattedValue.ToString(), row.Cells[3].FormattedValue.ToString(), row.Cells[0].FormattedValue.ToString());
        }
        Utilidades.CargarComboTratamientos(this);
        MessageBox.Show("¡Actualizado!", "Tratamientos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}