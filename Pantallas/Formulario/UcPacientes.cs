using HitoriaClinica.Pantallas.Formulario.Logic;
using System.Text.RegularExpressions;
using HitoriaClinica.DataBase;
using HitoriaClinica.Modelos;
using HitoriaClinica.Reportes;
using System.Globalization;
using System.Diagnostics;
using DinkToPdf;

namespace HitoriaClinica;

public partial class UcPacientes : UserControl
{
    #region Variables de clase

    public readonly List<string[,]> tratamientos = [];
    public int Estado = 1;
    public int Id_cliente = 0;
    public string ci_cliente = "";
    public DateTime FechaTratamietno;
    private readonly PdfGenerator pdfGenerator = new(new SynchronizedConverter(new PdfTools()));

    private readonly string basePath = AppDomain.CurrentDomain.BaseDirectory;
    private readonly string rutaRostroF = "Recursos\\Archivos\\RostroF.pdf";
    private readonly string rutaRostroM = "Recursos\\Archivos\\RostroM.pdf";
    private readonly string rutaCuerpoF = "Recursos\\Archivos\\CuerpoF.pdf";
    private readonly string rutaCuerpoM = "Recursos\\Archivos\\CuerpoM.pdf";
    private readonly string carpetaHistoriaClinica = "C:\\HistoriaClinica\\";

    #endregion

    #region Constructor

    public UcPacientes()
    {
        InitializeComponent();
        PreloadData();
        Utilidades.ShowPanels(1, this);
        cbSexo.SelectedIndex = 0;
        PbGaleria.Visible = PbRostro.Visible = PBmas.Visible = false;
    }

    #endregion

    public void GvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        Estado = 2;
        PbGaleria.Visible = PbRostro.Visible = PBmas.Visible = true;
        Id_cliente = Convert.ToInt32(Convert.ToInt32(GvConsulta.Rows[e.RowIndex].Cells["id"].Value.ToString()));
        Utilidades.ShowPanels(1, this);
        _ = CargarDatosCliente();
        _ = CargarAntecedentes();
        _ = CargarHabitosPsicobio();
        _ = CargarExamenFisico();
        _ = CargarHistorialTrata();
        MostrarNombrePaciente(true);
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
        ci_cliente = tbCedula.Text = cliente.Cedula ?? "";
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
        TimeSpan anos = (DateTime)DtNacimiendo.Value - DateTime.Now;
        DateTime edad = new(Math.Abs(anos.Ticks));
        tbEdad.Text = edad.Year - 1 + " años";
    }

    public void TbTele_TextChanged(object? sender, EventArgs e)
    {
        int selectionStart = TbTele.SelectionStart;
        int selectionLength = TbTele.SelectionLength;
        string newText = Regex.Replace(TbTele.Text, @"[^\d]", "");
        if (TbTele.Text != newText)
        {
            TbTele.Text = newText;
            TbTele.SelectionStart = Math.Min(selectionStart, TbTele.Text.Length);
            TbTele.SelectionLength = selectionLength;
        }
    }

    public async void GvConsulta_BtnImprimir_Click(object sender, DataGridViewCellEventArgs e)
    {
        if (DtpFechaConcen.Visible)
        {
            if (e.ColumnIndex == GvConsulta.Columns["BtnImprimir"].Index && e.RowIndex >= 0)
            {
                try
                {
                    string basePath = AppDomain.CurrentDomain.BaseDirectory;
                    string htmlTemplatePath = Path.Combine(basePath, "Reportes", "Modelos", "CosentimientoModelo.html");
                    string htmlCosentimientoPath = Path.Combine(basePath, "Reportes", "Modelos", "Cosentimiento.html");
                    string outputPdfPath = Path.Combine(basePath, "Reportes", "Modelos", "Ficha.pdf");
                    if (File.Exists(outputPdfPath)) File.Delete(outputPdfPath);
                    if (File.Exists(htmlCosentimientoPath)) File.Delete(htmlCosentimientoPath);
                    int idClient = Convert.ToInt32(GvConsulta.Rows[e.RowIndex].Cells["id"].Value);
                    Cliente clientInfo = await Consult.AsyncTraerInfoClientById(idClient);
                    string modelo = File.ReadAllText(htmlTemplatePath);
                    modelo = modelo.Replace("#NombrePaciente#", clientInfo.Nombre + " " + clientInfo.Apellido)
                                   .Replace("#DocumentoIdentidad#", clientInfo.Cedula)
                                   .Replace("#FechaProcedimiento#", DtpFechaConcen.Value.ToString("D", new CultureInfo("es-ES")))
                                   .Replace("#RutaCarpeta#", basePath + "Reportes\\Modelos\\");
                    File.WriteAllText(htmlCosentimientoPath, modelo);
                    pdfGenerator.GeneratePdfFromHtmlFile(htmlCosentimientoPath, outputPdfPath);

                    if (File.Exists(outputPdfPath))
                    {
                        try
                        {
                            ProcessStartInfo psi = new()
                            {
                                FileName = "cmd",
                                Arguments = $"/c start {outputPdfPath}",
                                WindowStyle = ProcessWindowStyle.Hidden
                            };

                            Process process = new()
                            {
                                StartInfo = psi
                            };

                            process.Start();
                            process.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error al abrir el archivo PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo PDF no se pudo generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == GvConsulta.Columns["BtnEliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult resul = MessageBox.Show("¿Seguro que quieres borrar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resul == DialogResult.Yes)
                {
                    int idClient = Convert.ToInt32(GvConsulta.Rows[e.RowIndex].Cells["id"].Value);
                    string cedula = GvConsulta.Rows[e.RowIndex].Cells["cedula"].Value.ToString() ?? "QWEASDZXCERTDFGCVB";
                    Delete.DeleteClient(idClient);
                    Delete.DeleteExamenFisico(idClient);
                    Delete.DeleteAntecedentesPersonales(idClient);
                    Delete.DeleteHabitosPsicobio(idClient);
                    Delete.DeleteHistorialTratamiento(idClient);
                    Delete.DeleteTratamientos(idClient);
                    _ = Utilidades.CargarGrila(this);

                    foreach (string dire in Directory.GetDirectories(carpetaHistoriaClinica))
                    {
                        if (dire.Contains(cedula))
                            Directory.Delete(dire, true);
                    }
                }
            }
        }
        else
        {
            DtpFechaConcen.Visible = true;
        }
    }

    public void BtnAgregar()
    {
        Estado = 1;
        Utilidades.Limpiar(this);
        Utilidades.CargarFechaHistorialTratamiento(this);
        Utilidades.CargarComboTratamientos(this);
        Utilidades.ShowPanels(1, this);
        PbGaleria.Visible = PbRostro.Visible = PBmas.Visible = false;
        MostrarNombrePaciente(false);
    }

    public void BtnBuscar()
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

        Utilidades.CargarFechaHistorialTratamiento(this);
        if (CbTratamientos.SelectedIndex == 0)
        {
            MessageBox.Show("Debe seleccionar un tratamiento", "No existe tratamiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            RtHistoTratamiento.Text += "\n------->" + CbTratamientos.Text + "\n" + (RtDescriTrata.Text.Trim() == "" ? "Ninguna\n" : RtDescriTrata.Text.Trim() + "\n");
            tratamientos.Add(new string[,] { { CbTratamientos?.SelectedValue?.ToString() ?? "0", RtDescriTrata.Text.Trim() } });

            if (CbTratamientos != null)
            {
                CbTratamientos.SelectedIndex = 0;
                RtDescriTrata.Text = "";
            }
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

        if (tbCedula.Text.Trim() == "")
        {
            MessageBox.Show("El capo cedula es obligatorio", "Cedula obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cbSexo.SelectedIndex == 0)
        {
            MessageBox.Show("El capo sexo es obligatorio", "Sexo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (Estado == 1)
        {
            #region Guarda

            if (Consult.ExistClient(tbCedula.Text).HasRows)
            {
                MessageBox.Show("Ya existe esta cedula", "Cedula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            if (!Directory.Exists(carpetaHistoriaClinica + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text))
            {
                string rutaCarpeta = carpetaHistoriaClinica + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text;
                Directory.CreateDirectory(rutaCarpeta);

                string sourceFilePathCuerpo = Path.Combine(basePath, cbSexo.SelectedIndex == 1 ? rutaCuerpoM : rutaCuerpoF);
                string sourceFilePathRostro = Path.Combine(basePath, cbSexo.SelectedIndex == 1 ? rutaRostroM : rutaRostroF);

                if (File.Exists(sourceFilePathRostro))
                {
                    File.Copy(sourceFilePathRostro, rutaCarpeta + "\\Rostro.pdf", true);
                }

                if (File.Exists(sourceFilePathCuerpo))
                {
                    File.Copy(sourceFilePathCuerpo, rutaCarpeta + "\\Cuerpo.pdf", true);
                }
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
        _ = Utilidades.CargarGrila(this);
        GvConsulta.Columns[2].Visible = false;
        Utilidades.Limpiar(this);
        Utilidades.CargarComboTratamientos(this);
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

    private void PbGaleria_Click(object sender, EventArgs e)
    {
        if (Estado == 2 && Directory.Exists("C:\\HistoriaClinica\\" + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text))
        {
            string carpeta = "C:\\HistoriaClinica\\" + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text;
            try
            {
                Process.Start("explorer.exe", carpeta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al abrir la carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void PbRostro_Click(object sender, EventArgs e)
    {
        string rostroPath = carpetaHistoriaClinica + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text + "\\Rostro.pdf";
        string cuerpoPath = carpetaHistoriaClinica + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text + "\\Cuerpo.pdf";

        if (File.Exists(rostroPath) && File.Exists(cuerpoPath))
        {
            try
            {
                Process.Start("explorer.exe", rostroPath);
                Process.Start("explorer.exe", cuerpoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al abrir los archivos PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Uno o ambos archivos PDF no se pudieron generar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PBmas_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("¿Quieres agregar un rostro?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        string rutaCarpeta = carpetaHistoriaClinica + tbCedula.Text + "-" + tbNombre.Text + "-" + TbApellido.Text;
        string ExtencionNombre = DateTime.Now.ToString("dd-MM hh-mm");
        string rutaArchivo = "";

        if (result == DialogResult.Yes)
        {
            rutaArchivo = Path.Combine(basePath, cbSexo.SelectedIndex == 1 ? rutaRostroM : rutaRostroF);

            if (File.Exists(rutaArchivo))
            {
                File.Copy(rutaArchivo, rutaCarpeta + "\\Rostro " + ExtencionNombre + ".pdf", true);
            }
        }
        else if (result == DialogResult.No)
        {
            rutaArchivo = Path.Combine(basePath, cbSexo.SelectedIndex == 1 ? rutaCuerpoM : rutaCuerpoF);
            if (File.Exists(rutaArchivo))
            {
                File.Copy(rutaArchivo, rutaCarpeta + "\\Cuerpo " + ExtencionNombre + ".pdf", true);
            }
        }

        if (File.Exists(rutaArchivo))
        {
            if (result == DialogResult.No)
            {
                MessageBox.Show("Archivo de cuerpo guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Archivo de rostro guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private async void PbBorrahisto_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("¿Segura que quieres borrar el historial?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result == DialogResult.Yes) result = MessageBox.Show("¿Segura?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            Delete.DeleteHistorialTratamiento(Id_cliente);
            Delete.DeleteTratamientos(Id_cliente);
        }

        await CargarHistorialTrata();
        MessageBox.Show("Historial borrado", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}