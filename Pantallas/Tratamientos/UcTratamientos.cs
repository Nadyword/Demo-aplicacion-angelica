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
    }

    #endregion
}