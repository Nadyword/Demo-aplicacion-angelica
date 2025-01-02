using HitoriaClinica.Pantallas.Formulario.Logic;
using HitoriaClinica.DataBase;
using System.Globalization;
using System.Text.RegularExpressions;

namespace HitoriaClinica;

public partial class UcPacientes : UserControl
{
    private readonly List<string[,]> tratamientos = [];

    public UcPacientes()
    {
        InitializeComponent();
        ShowPanels(1);
        RtHistoTratamiento.Text += RtHistoTratamiento.Text == "" ? "*---Fecha de tratamiento: " + DateTime.Now.ToString("D", new CultureInfo("es-ES")) + "---*" : "\n*---Fecha de tratamiento: " + DateTime.Now.ToString("D", new CultureInfo("es-ES")) + "---*";
        cbSexo.SelectedIndex = 0;
        CbTratamientos.DataSource = AgregarTratamiento.TraerTratamientos();
        CbTratamientos.DisplayMember = "Descripcion";
        CbTratamientos.ValueMember = "Id";
        CbTratamientos.SelectedIndex = 0;
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

    private void DtNacimiendo_ValueChanged(object? sender, EventArgs e)
    {
        DateTime Edad = DtNacimiendo.Value;
        tbEdad.Text = (DateTime.Now.Year - Edad.Year).ToString() + " años";
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
        TbOtros.Enabled = CbOtro.Checked;
        TbOtros.Text = !CbOtro.Checked ? "Niega" : "";
    }

    private void CbAlcho_CheckedChanged(object? sender, EventArgs e)
    {
        TbAlch.Enabled = CbAlcho.Checked;
        TbAlch.Text = !CbAlcho.Checked ? "Niega" : "";
    }

    private void CbFisica_CheckedChanged(object? sender, EventArgs e)
    {
        TbFisica.Enabled = CbFisica.Checked;
        TbFisica.Text = !CbFisica.Checked ? "Niega" : "";
    }

    private void CbTaba_CheckedChanged(object sender, EventArgs e)
    {
        TbTabaquis.Enabled = CbTaba.Checked;
        TbTabaquis.Text = !CbTaba.Checked ? "Niega" : "";
    }

    private void PbSiguiente_Click(object sender, EventArgs e)
    {
        ShowPanels(2);
    }

    private void BbAtras_Click(object sender, EventArgs e)
    {
        ShowPanels(1);
    }

    private void PbAgregar_Click(object sender, EventArgs e)
    {
        if (CbTratamientos.SelectedIndex == 0)
        {
            MessageBox.Show("Debe seleccionar un tratamiento", "No existe tratamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        RtHistoTratamiento.Text += "\n------->" + CbTratamientos.Text + "\n" + (RtDescriTrata.Text.Trim() == "" ? "Ninguna\n" : RtDescriTrata.Text.Trim() + "\n");

        tratamientos.Add(new string[,] { { CbTratamientos?.SelectedValue?.ToString() ?? "0", RtDescriTrata.Text.Trim() } });

        if (CbTratamientos != null)
        {
            CbTratamientos.SelectedIndex = 0;
            RtDescriTrata.Text = "";
        }
    }

    private void PbBorrar_Click(object sender, EventArgs e)
    {
        int IndexFecha = RtHistoTratamiento.Text.LastIndexOf("---*");
        int IndexTratamiento = RtHistoTratamiento.Text.LastIndexOf("------->") - 1;

        if (IndexFecha < IndexTratamiento)
        {
            RtHistoTratamiento.Text = RtHistoTratamiento.Text[..IndexTratamiento];
        }

        if (tratamientos.Count > 0)
        {
            tratamientos.RemoveAt(tratamientos.Count - 1);
        }
    }

    private void RbGuardar_Click(object sender, EventArgs e)
    {

        if (tbCedula.Text.Trim() == "")
        {
            MessageBox.Show("El capo cedula es obligatorio", "Cedula obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (Consult.ExistClient(tbCedula.Text).HasRows)
        {
            MessageBox.Show("Ya existe esta cedula", "Cedula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        else
        {
            Insert.InsertClient(tbNombre.Text.Trim(), TbApellido.Text.Trim(), tbCedula.Text.Trim(), TbTele.Text.Trim(), cbSexo.SelectedIndex, tbDireccion.Text.Trim(), TbOcupa.Text.Trim());
            int id = Consult.IdClient(tbCedula.Text.Trim());
            Insert.InsertAntecedente(id, tbExpliEnfer.Text.Trim(), TbExplAlergiaMed.Text.Trim(), TbExpliAlergAli.Text.Trim(), TbExpliCiru.Text.Trim(), TbExpliTrata.Text.Trim(), tbExpliBio.Text.Trim());
            Insert.InsertHabitoPsicobio(id, TbTabaquis.Text.Trim(), TbFisica.Text.Trim(), TbAlch.Text.Trim(), TbOtros.Text.Trim());
            Insert.InsertExamenFisico(id, RtExamenFisico.Text.Trim());
            Insert.InsertHistorialTratamiento(id, RtHistoTratamiento.Text.Trim());

            for (int i = 0; i < tratamientos.Count; i++)
            {
                Insert.InsertTratamiento(id, tratamientos[i][0, 0], tratamientos[i][0, 1]);
            }

            MessageBox.Show("¡Guardado!", "Registro creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}