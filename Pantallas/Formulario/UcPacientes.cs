using HitoriaClinica.Pantallas.Formulario.Logic;
using HitoriaClinica.DataBase;
using System.Globalization;
using System.Text.RegularExpressions;
using HitoriaClinica.Modelos;

namespace HitoriaClinica;

public partial class UcPacientes : UserControl
{
    #region Variables de clase

    private readonly List<string[,]> tratamientos = [];
    private int Estado = 1;
    private int Id_cliente = 0;

    #endregion

    #region Constructor

    public UcPacientes()
    {
        InitializeComponent();
        PreloadData();
        ShowPanels(1);
        RtHistoTratamiento.Text += RtHistoTratamiento.Text == "" ? "*---Fecha de tratamiento: " + DateTime.Now.ToString("D", new CultureInfo("es-ES")) + "---*" : "\n*---Fecha de tratamiento: " + DateTime.Now.ToString("D", new CultureInfo("es-ES")) + "---*";
        cbSexo.SelectedIndex = 0;
    }

    #endregion

    private void ToolStripMenuItemAgregar_Click(object sender, EventArgs e)
    {
        ShowPanels(1);
        Estado = 1;
        Limpiar();
    }

    private void GvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        Estado = 2;
        Id_cliente = Convert.ToInt32(Convert.ToInt32(GvConsulta.Rows[e.RowIndex].Cells[0].Value.ToString()));
        ShowPanels(1);
    }

    #region Utilidades

    private void Limpiar()
    {
        cbSexo.SelectedIndex = 0;
        DtNacimiendo.Text = DateTime.Now.ToString("D", new CultureInfo("es-ES"));
        CbEnfermedad.Checked = CbAlegiaMedi.Checked = CbAlergiAli.Checked = CbCiru.Checked = CbTrata.Checked =
        CbBiopoli.Checked = CbOtro.Checked = CbAlcho.Checked = CbFisica.Checked = CbTaba.Checked = false;

        tbNombre.Text = tbCedula.Text = TbApellido.Text = TbTele.Text = tbDireccion.Text = TbOcupa.Text = tbEdad.Text =
        tbExpliEnfer.Text = TbExplAlergiaMed.Text = TbExpliAlergAli.Text = TbExpliCiru.Text = TbExpliTrata.Text = tbExpliBio.Text =
        TbTabaquis.Text = TbFisica.Text = TbAlch.Text = TbOtros.Text = RtExamenFisico.Text = RtHistoTratamiento.Text = RtDescriTrata.Text = ""; tbNombre.Text = tbCedula.Text = TbApellido.Text = TbTele.Text = tbDireccion.Text = TbOcupa.Text = tbEdad.Text =
        tbExpliEnfer.Text = TbExplAlergiaMed.Text = TbExpliAlergAli.Text = TbExpliCiru.Text = TbExpliTrata.Text = tbExpliBio.Text =
        TbTabaquis.Text = TbFisica.Text = TbAlch.Text = TbOtros.Text = RtExamenFisico.Text = RtHistoTratamiento.Text = RtDescriTrata.Text = "";
    }

    private void TbBuscar_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            GvConsulta.DataSource = TraerClientes.TraerCliente(TbBuscar.Text.Trim());
        }
    }

    private void ShowPanels(int Panel)
    {
        SuspendLayout();
        switch (Panel)
        {
            case 1:
                PanelFromulario1.Visible = true;
                PanelFromulario2.Visible = false;
                PanelFromulario3.Visible = false;
                break;
            case 2:
                PanelFromulario1.Visible = false;
                PanelFromulario2.Visible = true;
                PanelFromulario3.Visible = false;
                break;
            case 3:
                PanelFromulario1.Visible = false;
                PanelFromulario2.Visible = false;
                PanelFromulario3.Visible = true;
                break;
        }

        ResumeLayout();
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

    #endregion

    #region Botones

    private void ToolStripMenuItemConsultar_Click(object sender, EventArgs e)
    {
        Estado = 2;
        ShowPanels(3);
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
        if (Estado == 1)
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
                Insert.InsertClient(new Cliente
                {
                    Nombre = tbNombre.Text.Trim(),
                    Apellido = TbApellido.Text.Trim(),
                    Cedula = tbCedula.Text.Trim(),
                    Telefono = Convert.ToInt64(TbTele.Text.Trim()),
                    Sexo = cbSexo.SelectedIndex,
                    Direccion = tbDireccion.Text.Trim(),
                    Ocupacion = TbOcupa.Text.Trim(),
                    Nacimiento = DtNacimiendo.Value.ToString()
                });

                int id = Consult.IdClient(tbCedula.Text.Trim());

                Insert.InsertAntecedente(new Antecedente
                {
                    ClienteId = id,
                    Enfermedad = tbExpliEnfer.Text.Trim(),
                    AlergiaMedicamentos = TbExplAlergiaMed.Text.Trim(),
                    AlergiaAlimentos = TbExpliAlergAli.Text.Trim(),
                    Cirugias = TbExpliCiru.Text.Trim(),
                    Tratamientos = TbExpliTrata.Text.Trim(),
                    Biopsias = tbExpliBio.Text.Trim()
                });

                Insert.InsertHabitoPsicobio(new HabitoPsicobio
                {
                    ClienteId = id,
                    Tabaquismo = TbTabaquis.Text.Trim(),
                    ActividadFisica = TbFisica.Text.Trim(),
                    Alcoholismo = TbAlch.Text.Trim(),
                    Otros = TbOtros.Text.Trim()
                });

                Insert.InsertExamenFisico(new ExamenFisico
                {
                    ClienteId = id,
                    Descripcion = RtExamenFisico.Text.Trim()
                });

                Insert.InsertHistorialTratamiento(new HistorialTratamiento
                {
                    ClienteId = id,
                    Descripcion = RtHistoTratamiento.Text.Trim()
                });

                for (int i = 0; i < tratamientos.Count; i++)
                {
                    Insert.InsertTratamiento( new Tratamiento
                    {
                        Id = id,
                        Descripcion = tratamientos[i][0, 1],
                        Id_trata = tratamientos[i][0, 0]
                    });
                }

                MessageBox.Show("¡Guardado!", "Registro creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }

    #endregion

    #region Checked (Niega)

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

    #endregion

    #region PreloadData

    private void PreloadData()
    {
        PanelFromulario1.Visible = false;
        PanelFromulario2.Visible = false;
        PanelFromulario3.Visible = false;
        CargarComboTratatamientos();
        CargarGrila();
        GvConsulta.Columns[0].Visible = false;
    }

    private void CargarGrila()
    {
        GvConsulta.DataSource = TraerClientes.TraerAllClientes();
    }

    private void CargarComboTratatamientos()
    {
        CbTratamientos.DataSource = AgregarTratamiento.TraerTratamientos();
        CbTratamientos.DisplayMember = "Descripcion";
        CbTratamientos.ValueMember = "Id";
        CbTratamientos.SelectedIndex = 0;
    }

    #endregion
}