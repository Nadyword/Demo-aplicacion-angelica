using HitoriaClinica.Pantallas.Formulario.Logic;
using HitoriaClinica.DataBase;
using System.Text.RegularExpressions;
using HitoriaClinica.Modelos;

namespace HitoriaClinica;

public partial class UcPacientes : UserControl
{
    #region Variables de clase

    public readonly List<string[,]> tratamientos = [];
    public int Estado = 1;
    public int Id_cliente = 0;

    #endregion

    #region Constructor

    public UcPacientes()
    {
        InitializeComponent();
        PreloadData();
        Utilidades.CargarFechaHistorialTratamiento(this);
        Utilidades.ShowPanels(1, this);
        cbSexo.SelectedIndex = 0;
    }

    #endregion


    public void GvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        Estado = 2;
        Id_cliente = Convert.ToInt32(Convert.ToInt32(GvConsulta.Rows[e.RowIndex].Cells[1].Value.ToString()));
        Utilidades.ShowPanels(1, this);
        _ = CargarDatosCliente();
        _ = CargarAntecedentes();
        _ = CargarHabitosPsicobio();
        _ = CargarExamenFisico();
        _ = CargarHistorialTrata();
        MostrarNombrePaciente(true);
        Utilidades.CargarFechaHistorialTratamiento(this);
    }

    public void TbBuscar_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            GvConsulta.DataSource = TraerClientes.TraerCliente(TbBuscar.Text.Trim());
        }
    }

    #region Utilidades

    public async Task CargarHistorialTrata()
    {
        HistorialTratamiento historialTratamiento = await Consult.AsyncTraerInfoHistorial_tratamientoById(Id_cliente.ToString());
        RtHistoTratamiento.Text = historialTratamiento.Descripcion;
    }

    public async Task CargarExamenFisico()
    {
        ExamenFisico examenFisico = await Consult.AsyncTraerInfoExamen_fisicoById(Id_cliente.ToString());
        RtExamenFisico.Text = examenFisico.Descripcion;
    }

    public async Task CargarHabitosPsicobio()
    {
        HabitoPsicobio habitoPsicobio = await Consult.AsyncTraerInfoHabitos_psicobiosById(Id_cliente.ToString());
        if (CbTaba.Checked = habitoPsicobio.Tabaquismo != "Niega") TbTabaquis.Text = habitoPsicobio.Tabaquismo;
        if (CbFisica.Checked = habitoPsicobio.ActividadFisica != "Niega") TbFisica.Text = habitoPsicobio.ActividadFisica;
        if (CbAlcho.Checked = habitoPsicobio.Alcoholismo != "Niega") TbAlch.Text = habitoPsicobio.Alcoholismo;
        if (CbOtro.Checked = habitoPsicobio.Otros != "Niega") TbOtros.Text = habitoPsicobio.Otros;
    }

    public async Task CargarAntecedentes()
    {
        Antecedente antecedente = await Consult.AsyncTraerInfoAntecedentes_personalesById(Id_cliente.ToString());
        if (CbEnfermedad.Checked = antecedente.Enfermedad != "Niega") tbExpliEnfer.Text = antecedente.Enfermedad;
        if (CbAlegiaMedi.Checked = antecedente.AlergiaMedicamentos != "Niega") TbExplAlergiaMed.Text = antecedente.AlergiaMedicamentos;
        if (CbAlergiAli.Checked = antecedente.AlergiaAlimentos != "Niega") TbExpliAlergAli.Text = antecedente.AlergiaAlimentos;
        if (CbCiru.Checked = antecedente.Cirugias != "Niega") TbExpliCiru.Text = antecedente.Cirugias;
        if (CbTrata.Checked = antecedente.Tratamientos != "Niega") TbExpliTrata.Text = antecedente.Tratamientos;
        if (CbBiopoli.Checked = antecedente.Biopsias != "Niega") tbExpliBio.Text = antecedente.Biopsias;
    }

    public async Task CargarDatosCliente()
    {
        Cliente cliente = await Consult.AsyncTraerInfoClientById(Id_cliente);
        tbNombre.Text = cliente.Nombre;
        TbApellido.Text = cliente.Apellido;
        tbCedula.Text = cliente.Cedula;
        TbTele.Text = cliente.Telefono.ToString();
        cbSexo.SelectedIndex = cliente.Sexo ?? 0;
        tbDireccion.Text = cliente.Direccion;
        TbOcupa.Text = cliente.Ocupacion;
        DtNacimiendo.Value = Convert.ToDateTime(cliente.Nacimiento);
    }

    public void MostrarNombrePaciente(bool Mostrar)
    {
        LbPaciente.Text = (Mostrar ? "Paciente: " + tbNombre.Text + " " + TbApellido.Text : "");
    }

    public void DtNacimiendo_ValueChanged(object? sender, EventArgs e)
    {
        DateTime Edad = DtNacimiendo.Value;
        tbEdad.Text = (DateTime.Now.Year - Edad.Year).ToString() + " años";
    }

    public void TbTele_TextChanged(object? sender, EventArgs e)
    {
        int selectionStart = TbTele.SelectionStart - 1;
        TbTele.Text = Regex.Replace(TbTele.Text, @"[^\d]", "");
        TbTele.SelectionStart = Math.Max(0, selectionStart);
    }

    #endregion

    #region Botones

    public void ToolStripMenuItemAgregar_Click(object sender, EventArgs e)
    {
        Utilidades.ShowPanels(1, this);
        Estado = 1;
        Utilidades.Limpiar(this);
        MostrarNombrePaciente(false);
    }

    public void ToolStripMenuItemConsultar_Click(object sender, EventArgs e)
    {
        Estado = 2;
        Utilidades.ShowPanels(3, this);
    }

    public void PbSiguiente_Click(object sender, EventArgs e)
    {
        Utilidades.ShowPanels(2, this);
    }

    public void BbAtras_Click(object sender, EventArgs e)
    {
        Utilidades.ShowPanels(1, this);
    }

    public void PbAgregar_Click(object sender, EventArgs e)
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

    public void PbBorrar_Click(object sender, EventArgs e)
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

    public void RbGuardar_Click(object sender, EventArgs e)
    {

        Utilidades.ValidarCampos(this);

        if (Estado == 1)
        {
            #region Guarda

            Insert.InsertClient(new Cliente
            {
                Nombre = tbNombre.Text.Trim(),
                Apellido = TbApellido.Text.Trim(),
                Cedula = tbCedula.Text.Trim(),
                Telefono = Convert.ToInt64(TbTele.Text.Trim() == "" ? "0" : TbTele.Text.Trim()),
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
                Insert.InsertTratamiento(new Tratamiento
                {
                    Id = id,
                    Descripcion = tratamientos[i][0, 1],
                    Id_trata = tratamientos[i][0, 0]
                });
            }

            _ = Utilidades.CargarGrila(this);
            MessageBox.Show("¡Guardado!", "Registro creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;

            #endregion
        }
        else
        {
            #region Actualizar

            Updates.UpdateClient(new Cliente
            {
                Id = Id_cliente,
                Nombre = tbNombre.Text.Trim(),
                Apellido = TbApellido.Text.Trim(),
                Cedula = tbCedula.Text.Trim(),
                Telefono = Convert.ToInt64(TbTele.Text.Trim() == "" ? "0" : TbTele.Text.Trim()),
                Sexo = cbSexo.SelectedIndex,
                Direccion = tbDireccion.Text.Trim(),
                Ocupacion = TbOcupa.Text.Trim(),
                Nacimiento = DtNacimiendo.Value.ToString()
            });

            for (int i = 0; i < tratamientos.Count; i++)
            {
                Insert.InsertTratamiento(new Tratamiento
                {
                    Id = Id_cliente,
                    Descripcion = tratamientos[i][0, 1],
                    Id_trata = tratamientos[i][0, 0]
                });
            }

            Updates.UpdateAntecedente(new Antecedente
            {
                ClienteId = Id_cliente,
                Enfermedad = tbExpliEnfer.Text.Trim(),
                AlergiaMedicamentos = TbExplAlergiaMed.Text.Trim(),
                AlergiaAlimentos = TbExpliAlergAli.Text.Trim(),
                Cirugias = TbExpliCiru.Text.Trim(),
                Tratamientos = TbExpliTrata.Text.Trim(),
                Biopsias = tbExpliBio.Text.Trim()
            });

            Updates.UpdateHabitoPsicobio(new HabitoPsicobio
            {
                ClienteId = Id_cliente,
                Tabaquismo = TbTabaquis.Text.Trim(),
                ActividadFisica = TbFisica.Text.Trim(),
                Alcoholismo = TbAlch.Text.Trim(),
                Otros = TbOtros.Text.Trim()
            });

            Updates.UpdateExamenFisico(new ExamenFisico
            {
                ClienteId = Id_cliente,
                Descripcion = RtExamenFisico.Text.Trim()
            });

            Updates.UpdateHistorialTratamiento(new HistorialTratamiento
            {
                ClienteId = Id_cliente,
                Descripcion = RtHistoTratamiento.Text.Trim()
            });

            _ = Utilidades.CargarGrila(this);
            MessageBox.Show("¡Guardado!", "Registro actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }
    }

    #endregion

    #region PreloadData

    public void PreloadData()
    {
        PanelFromulario1.Visible = false;
        PanelFromulario2.Visible = false;
        PanelFromulario3.Visible = false;
        Utilidades.CargarComboTratamientos(this);
        _ = Utilidades.CargarGrila(this);
        GvConsulta.Columns[1].Visible = false;
        Utilidades.Limpiar(this);
    }

    #endregion

    #region Checked (Niega)

    public void CbEnfermedad_CheckedChanged(object? sender, EventArgs? e)
    {
        tbExpliEnfer.Enabled = CbEnfermedad.Checked;
        tbExpliEnfer.Text = !CbEnfermedad.Checked ? "Niega" : "";
    }

    public void CbAlegiaMedi_CheckedChanged(object? sender, EventArgs? e)
    {
        TbExplAlergiaMed.Enabled = CbAlegiaMedi.Checked;
        TbExplAlergiaMed.Text = !CbAlegiaMedi.Checked ? "Niega" : "";
    }

    public void CbAlergiAli_CheckedChanged(object? sender, EventArgs? e)
    {
        TbExpliAlergAli.Enabled = CbAlergiAli.Checked;
        TbExpliAlergAli.Text = !CbAlergiAli.Checked ? "Niega" : "";
    }

    public void CbCiru_CheckedChanged(object? sender, EventArgs? e)
    {
        TbExpliCiru.Enabled = CbCiru.Checked;
        TbExpliCiru.Text = !CbCiru.Checked ? "Niega" : "";
    }

    public void CbTrata_CheckedChanged(object? sender, EventArgs? e)
    {
        TbExpliTrata.Enabled = CbTrata.Checked;
        TbExpliTrata.Text = !CbTrata.Checked ? "Niega" : "";
    }

    public void CbBiopoli_CheckedChanged(object? sender, EventArgs? e)
    {
        tbExpliBio.Enabled = CbBiopoli.Checked;
        tbExpliBio.Text = !CbBiopoli.Checked ? "Niega" : "";
    }

    public void CbOtro_CheckedChanged(object? sender, EventArgs? e)
    {
        TbOtros.Enabled = CbOtro.Checked;
        TbOtros.Text = !CbOtro.Checked ? "Niega" : "";
    }

    public void CbAlcho_CheckedChanged(object? sender, EventArgs? e)
    {
        TbAlch.Enabled = CbAlcho.Checked;
        TbAlch.Text = !CbAlcho.Checked ? "Niega" : "";
    }

    public void CbFisica_CheckedChanged(object? sender, EventArgs? e)
    {
        TbFisica.Enabled = CbFisica.Checked;
        TbFisica.Text = !CbFisica.Checked ? "Niega" : "";
    }

    public void CbTaba_CheckedChanged(object? sender, EventArgs? e)
    {
        TbTabaquis.Enabled = CbTaba.Checked;
        TbTabaquis.Text = !CbTaba.Checked ? "Niega" : "";
    }

    #endregion
}