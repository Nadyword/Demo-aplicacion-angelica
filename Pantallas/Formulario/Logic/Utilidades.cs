using System.Globalization;


namespace HitoriaClinica.Pantallas.Formulario.Logic;

internal class Utilidades
{
    public static void Limpiar(UcPacientes _ucPacientes)
    {
        _ucPacientes.cbSexo.SelectedIndex = 0;
        _ucPacientes.DtNacimiendo.Text = DateTime.Now.ToString("D", new CultureInfo("es-ES"));
        _ucPacientes.CbEnfermedad.Checked = _ucPacientes.CbAlegiaMedi.Checked = _ucPacientes.CbAlergiAli.Checked = _ucPacientes.CbCiru.Checked = _ucPacientes.CbTrata.Checked =
        _ucPacientes.CbBiopoli.Checked = _ucPacientes.CbOtro.Checked = _ucPacientes.CbAlcho.Checked = _ucPacientes.CbFisica.Checked = _ucPacientes.CbTaba.Checked = false;

        _ucPacientes.tbNombre.Text = _ucPacientes.tbCedula.Text = _ucPacientes.TbApellido.Text = _ucPacientes.TbTele.Text = _ucPacientes.tbDireccion.Text = _ucPacientes.TbOcupa.Text = _ucPacientes.tbEdad.Text =
        _ucPacientes.tbExpliEnfer.Text = _ucPacientes.TbExplAlergiaMed.Text = _ucPacientes.TbExpliAlergAli.Text = _ucPacientes.TbExpliCiru.Text = _ucPacientes.TbExpliTrata.Text = _ucPacientes.tbExpliBio.Text =
        _ucPacientes.TbTabaquis.Text = _ucPacientes.TbFisica.Text = _ucPacientes.TbAlch.Text = _ucPacientes.TbOtros.Text = _ucPacientes.RtExamenFisico.Text = _ucPacientes.RtHistoTratamiento.Text = _ucPacientes.RtDescriTrata.Text = "";

        _ucPacientes.CbEnfermedad_CheckedChanged(null, null);
        _ucPacientes.CbAlegiaMedi_CheckedChanged(null, null);
        _ucPacientes.CbAlergiAli_CheckedChanged(null, null);
        _ucPacientes.CbCiru_CheckedChanged(null, null);
        _ucPacientes.CbTrata_CheckedChanged(null, null);
        _ucPacientes.CbBiopoli_CheckedChanged(null, null);
        _ucPacientes.CbOtro_CheckedChanged(null, null);
        _ucPacientes.CbAlcho_CheckedChanged(null, null);
        _ucPacientes.CbFisica_CheckedChanged(null, null);
        _ucPacientes.CbTaba_CheckedChanged(null, null);
    }

    public static void ShowPanels(int Panel, UcPacientes ucPacientes)
    {
        ucPacientes.SuspendLayout();
        switch (Panel)
        {
            case 1:
                ucPacientes.PanelFromulario1.Visible = true;
                ucPacientes.PanelFromulario2.Visible = false;
                ucPacientes.PanelFromulario3.Visible = false;
                ucPacientes.PanelFromulario3.Visible = false;
                break;
            case 2:
                ucPacientes.PanelFromulario1.Visible = false;
                ucPacientes.PanelFromulario2.Visible = true;
                ucPacientes.PanelFromulario3.Visible = false;
                ucPacientes.PanelFromulario3.Visible = false;
                break;
            case 3:
                ucPacientes.PanelFromulario1.Visible = false;
                ucPacientes.PanelFromulario2.Visible = false;
                ucPacientes.PanelFromulario3.Visible = true;
                ucPacientes.PbRostro.Visible = ucPacientes.PbGaleria.Visible = ucPacientes.PBmas.Visible = ucPacientes.DtpFechaConcen.Visible = false;
                break;
        }
        ucPacientes.ResumeLayout();
    }

    public static void CargarComboTratamientos(UcPacientes ucPacientes)
    {
        ucPacientes.CbTratamientos.DataSource = AgregarTratamiento.TraerTratamientos();
        ucPacientes.CbTratamientos.DisplayMember = "Descripcion";
        ucPacientes.CbTratamientos.ValueMember = "Id";
        ucPacientes.CbTratamientos.SelectedIndex = 0;
    }

    public static async Task CargarGrila(UcPacientes ucPacientes)
    {
        ucPacientes.GvConsulta.DataSource = await TraerClientes.TraerAllClientes();
    }

    public static void CargarFechaHistorialTratamiento(UcPacientes ucPacientes)
    {
        if (ucPacientes.FechaTratamietno != ucPacientes.DtTratamiento.Value && ucPacientes.CbTratamientos.SelectedIndex != 0)
        {
            ucPacientes.RtHistoTratamiento.Text += ucPacientes.RtHistoTratamiento.Text == "" ? "*---Fecha de tratamiento: " + ucPacientes.DtTratamiento.Value.ToString("D", new CultureInfo("es-ES")) + "---*" : "\n*---Fecha de tratamiento: " + ucPacientes.DtTratamiento.Value.ToString("D", new CultureInfo("es-ES")) + "---*";
            ucPacientes.FechaTratamietno = ucPacientes.DtTratamiento.Value;
        }
    }
}
