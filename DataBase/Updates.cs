using HitoriaClinica.Modelos;

namespace HitoriaClinica.DataBase;

internal class Updates : Connection
{
    public static void UpdateClient(Cliente cliente)
    {
        ExecuteNonQuery($"UPDATE clientes SET nombre = '{cliente.Nombre}', apellido = '{cliente.Apellido}', cedula = '{cliente.Cedula}', telefono = '{cliente.Telefono}', sexo = {cliente.Sexo}, direccion = '{cliente.Direccion}', ocupacion = '{cliente.Ocupacion}', Nacimiento = '{cliente.Nacimiento}' WHERE id = {cliente.Id};");
    }

    public static void UpdateAntecedente(Antecedente antecedente)
    {
        ExecuteNonQuery($"UPDATE antecedentes_personales SET enfermedad_cronica = '{antecedente.Enfermedad}', alergia_medicamentos = '{antecedente.AlergiaMedicamentos}', alergia_alimentos = '{antecedente.AlergiaAlimentos}', cirugias = '{antecedente.Cirugias}', tratamientos_esteticos = '{antecedente.Tratamientos}', biopolimeros = '{antecedente.Biopsias}' WHERE cliente_id = {antecedente.ClienteId};");
    }

    public static void UpdateHabitoPsicobio(HabitoPsicobio habitoPsicobio)
    {
        ExecuteNonQuery($"UPDATE habitos_psicobio SET tabaquismo = '{habitoPsicobio.Tabaquismo}', actividad_fisica = '{habitoPsicobio.ActividadFisica}', alcohol = '{habitoPsicobio.Alcoholismo}', estres = '{habitoPsicobio.Otros}' WHERE cliente_id = {habitoPsicobio.ClienteId};");
    }

    public static void UpdateExamenFisico(ExamenFisico examenFisico)
    {
        ExecuteNonQuery($"UPDATE examen_fisico SET descripcion = '{examenFisico.Descripcion}' WHERE cliente_id = {examenFisico.ClienteId};");
    }

    public static void UpdateHistorialTratamiento(HistorialTratamiento historialTratamiento)
    {
        ExecuteNonQuery($"UPDATE historial_tratamiento SET descripcion = '{historialTratamiento.Descripcion}' WHERE cliente_id = {historialTratamiento.ClienteId};");
    }

    public static void UpdateTratamiento(Tratamiento tratamiento)
    {
        string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        ExecuteNonQuery($"UPDATE tratamientos SET descripcion = '{tratamiento.Descripcion}', fecha = '{fecha}', id_trata = '{tratamiento.Id_trata}' WHERE cliente_id = {tratamiento.Id};");
    }
}
