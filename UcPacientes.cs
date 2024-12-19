using System.Text.RegularExpressions;

namespace Demo_aplicacion_angelica_V1;

public partial class UcPacientes : UserControl
{
    public UcPacientes()
    {
        InitializeComponent();
        ShowPanels(1);
        DtNacimiendo.ValueChanged += DtNacimiendo_ValueChanged;
        TbTele.TextChanged += TbTele_TextChanged;
        cbSexo.SelectedIndex = 0;
        CbEnfermedad.CheckedChanged += CbEnfermedad_CheckedChanged;
        CbAlegiaMedi.CheckedChanged += CbAlegiaMedi_CheckedChanged;
        CbAlergiAli.CheckedChanged += CbAlergiAli_CheckedChanged;
        CbCiru.CheckedChanged += CbCiru_CheckedChanged;
        CbTrata.CheckedChanged += CbTrata_CheckedChanged;
        CbBiopoli.Click += CbBiopoli_CheckedChanged;
        CbOtro.CheckedChanged += CbOtro_CheckedChanged;
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
    }

    private void DtNacimiendo_ValueChanged(object? sender, EventArgs e)
    {
        DateTime Edad = DtNacimiendo.Value;
        tbEdad.Text = (DateTime.Now.Year - Edad.Year).ToString() + "Años";
    }

    private void TbTele_TextChanged(object? sender, EventArgs e)
    {
        int selectionStart = TbTele.SelectionStart - 1;
        TbTele.Text = Regex.Replace(TbTele.Text, @"[^\d]", "");
        TbTele.SelectionStart = Math.Max(0, selectionStart);
    }

    private void CbEnfermedad_CheckedChanged(object? sender, EventArgs e)
    {
        tbExpliEnfer.Enabled = CbEnfermedad.Checked;
        tbExpliEnfer.Text = !CbEnfermedad.Checked ? "Niega" : "";
    }

    private void CbAlegiaMedi_CheckedChanged(object? sender, EventArgs e)
    {
        TbExplAlergiaMed.Enabled = CbAlegiaMedi.Checked;
        TbExplAlergiaMed.Text = !CbAlegiaMedi.Checked ? "Niega" : "";
    }

    private void CbAlergiAli_CheckedChanged(object? sender, EventArgs e)
    {
        TbExpliAlergAli.Enabled = CbAlergiAli.Checked;
        TbExpliAlergAli.Text = !CbAlergiAli.Checked ? "Niega" : "";
    }

    private void CbCiru_CheckedChanged(object? sender, EventArgs e)
    {
        TbExpliCiru.Enabled = CbCiru.Checked;
        TbExpliCiru.Text = !CbCiru.Checked ? "Niega" : "";
    }

    private void CbTrata_CheckedChanged(object? sender, EventArgs e)
    {
        TbExpliTrata.Enabled = CbTrata.Checked;
        TbExpliTrata.Text = !CbTrata.Checked ? "Niega" : "";
    }

    private void CbBiopoli_CheckedChanged(object? sender, EventArgs e)
    {
        tbExpliBio.Enabled = CbBiopoli.Checked;
        tbExpliBio.Text = !CbBiopoli.Checked ? "Niega" : "";
    }

    private void CbOtro_CheckedChanged(object? sender, EventArgs e)
    {
        TbOtros.Visible = CbOtro.Checked;
    }
}
