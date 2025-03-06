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
        GvTratamientos.Columns[1].Visible = false;
        GvTratamientos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        GvTratamientos.Rows[1].ReadOnly = true;
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

    private void GvTratamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DialogResult resul = MessageBox.Show("¿Seguro que quieres borrar el tratamiento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (resul == DialogResult.Yes)
        {
            if (e.ColumnIndex == GvTratamientos.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(GvTratamientos.Rows[e.RowIndex].Cells["id"].Value);
                Delete.DeleteTratamientosCombo(id);
            }
            Utilidades.CargarComboTratamientos(this);
        }
    }
}