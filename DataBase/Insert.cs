using HitoriaClinica.Modelos;

namespace HitoriaClinica.DataBase
{
    internal class Insert : Connection
    {
        public static void InsertClient(Cliente cliente)
        {
            ExecuteNonQuery($"INSERT INTO clientes (nombre, apellido, cedula, telefono, sexo, direccion, ocupacion, Nacimiento) VALUES ('{cliente.Nombre}', '{cliente.Apellido}', '{cliente.Cedula}', '{cliente.Telefono}', {cliente.Sexo}, '{cliente.Direccion}', '{cliente.Ocupacion}', '{cliente.Nacimiento}');");
        }

        public static void InsertAntecedente(Antecedente antecedente)
        {
            ExecuteNonQuery($"INSERT INTO antecedentes_personales (cliente_id, enfermedad_cronica, alergia_medicamentos, alergia_alimentos, cirugias, tratamientos_esteticos, biopolimeros) VALUES ({antecedente.ClienteId}, '{antecedente.Enfermedad}', '{antecedente.AlergiaMedicamentos}', '{antecedente.AlergiaAlimentos}', '{antecedente.Cirugias}', '{antecedente.Tratamientos}', '{antecedente.Biopsias}');");
        }

        public static void InsertHabitoPsicobio(HabitoPsicobio habitoPsicobio)
        {
            ExecuteNonQuery($"INSERT INTO habitos_psicobio (cliente_id, tabaquismo, actividad_fisica, alcohol, estres) VALUES ({habitoPsicobio.ClienteId}, '{habitoPsicobio.Tabaquismo}', '{habitoPsicobio.ActividadFisica}', '{habitoPsicobio.Alcoholismo}', '{habitoPsicobio.Otros}');");
        }

        public static void InsertExamenFisico(ExamenFisico examenFisico)
        {
            ExecuteNonQuery($"INSERT INTO examen_fisico (cliente_id, descripcion) VALUES ({examenFisico.ClienteId}, '{examenFisico.Descripcion}');");
        }

        public static void InsertHistorialTratamiento(HistorialTratamiento historialTratamiento)
        {
            ExecuteNonQuery($"INSERT INTO historial_tratamiento (cliente_id, descripcion) VALUES ({historialTratamiento.ClienteId}, '{historialTratamiento.Descripcion}');");
        }

        public static void InsertTratamiento(Tratamiento tratamiento)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            ExecuteNonQuery($"INSERT INTO tratamientos (cliente_id, descripcion, fecha, id_trata) VALUES ({tratamiento.Id}, '{tratamiento.Descripcion}', '{fecha}', '{tratamiento.Id_trata}');");
        }
    }
}
