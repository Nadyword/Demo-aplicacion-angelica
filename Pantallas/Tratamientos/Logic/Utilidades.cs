using HitoriaClinica.Pantallas.Formulario.Logic;

namespace HitoriaClinica.Pantallas.Tratamientos.Logic;

internal class Utilidades
{
    public static void CargarComboTratamientos(UcTratamientos ucTratamientos)
    {
        ucTratamientos.GvTratamientos.DataSource = AgregarTratamiento.TraerTratamientosWithOrder();
    }
}
