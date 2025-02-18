using HitoriaClinica.Pantallas.Formulario.Logic;

namespace HitoriaClinica.Pantallas.Tratamientos.Logic;

internal class Utilidades
{
    public static void CargarComboTratamientos(UcTratamientos ucTratamientos)
    {
        ucTratamientos.GvTratamientos.DataSource = AgregarTratamiento.TraerTratamientosWithOrder();
    }

    public static void IniciarCarga(UcTratamientos ucTratamientos)
    {
        ucTratamientos.BarraCarga.Style = ProgressBarStyle.Marquee;
        ucTratamientos.BarraCarga.MarqueeAnimationSpeed = 20;
        ucTratamientos.BarraCarga.Visible = true;
    }

    public static void DetenerCarga(UcTratamientos ucTratamientos)
    {
        ucTratamientos.BarraCarga.Style = ProgressBarStyle.Blocks;
        ucTratamientos.BarraCarga.MarqueeAnimationSpeed = 0;
        ucTratamientos.BarraCarga.Visible = false;
    }
}
