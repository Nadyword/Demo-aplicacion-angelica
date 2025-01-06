using System.Collections.Generic;

namespace HitoriaClinica.DataBase
{
    public static class PanelCache
    {
        public static Dictionary<string, Panel> Paneles { get; private set; } = new Dictionary<string, Panel>();

        public static void PreloadPanels(UcPacientes ucPacientes)
        {
            Paneles["PanelFromulario1"] = ucPacientes.PanelFromulario1;
            Paneles["PanelFromulario2"] = ucPacientes.PanelFromulario2;
            Paneles["PanelFromulario3"] = ucPacientes.PanelFromulario3;
        }
    }
}
