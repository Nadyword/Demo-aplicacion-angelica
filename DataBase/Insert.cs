using System.Collections.Generic;

namespace HitoriaClinica.DataBase
{
    internal class Insert : Connection
    {
        public static void InsertClient(string NOMBRE, string APELLIDO, string CEDULA, string TELEFONO, int SEXO, string DIRECCION, string OCUPACION)
        {
            ExecuteNonQuery($"INSERT INTO clientes (nombre, apellido, cedula, telefono, sexo, direccion, ocupacion) VALUES ('{NOMBRE}', '{APELLIDO}', '{CEDULA}', '{TELEFONO}', {SEXO}, '{DIRECCION}', '{OCUPACION}');");
        }

        public static void InsertAntecedente(int CLIENTE_ID, string ENFERMEDAD_CRONICA, string ALERGIA_MEDICAMENTOS, string ALERGIA_ALIMENTOS, string CIRUGIAS, string TRATAMIENTOS_ESTETICOS, string BIOPOLIMEROS)
        {
            ExecuteNonQuery($"INSERT INTO antecedentes_personales (cliente_id, enfermedad_cronica, alergia_medicamentos, alergia_alimentos, cirugias, tratamientos_esteticos, biopolimeros) VALUES ({CLIENTE_ID}, '{ENFERMEDAD_CRONICA}', '{ALERGIA_MEDICAMENTOS}', '{ALERGIA_ALIMENTOS}', '{CIRUGIAS}', '{TRATAMIENTOS_ESTETICOS}', '{BIOPOLIMEROS}');");
        }

        public static void InsertHabitoPsicobio(int CLIENTE_ID, string TABAQUISMO, string ACTIVIDAD_FISICA, string ALCOHOL, string ESTRES)
        {
            ExecuteNonQuery($"INSERT INTO habitos_psicobio (cliente_id, tabaquismo, actividad_fisica, alcohol, estres) VALUES ({CLIENTE_ID}, '{TABAQUISMO}', '{ACTIVIDAD_FISICA}', '{ALCOHOL}', '{ESTRES}');");
        }

        public static void InsertExamenFisico(int CLIENTE_ID, string DESCRIPCION)
        {
            ExecuteNonQuery($"INSERT INTO examen_fisico (cliente_id, descripcion) VALUES ({CLIENTE_ID}, '{DESCRIPCION}');");
        }

        public static void InsertHistorialTratamiento(int CLIENTE_ID, string DESCRIPCION)
        {
            ExecuteNonQuery($"INSERT INTO historial_tratamiento (cliente_id, descripcion) VALUES ({CLIENTE_ID}, '{DESCRIPCION}');");
        }

        public static void InsertTratamiento(int CLIENTE_ID, string ID_TRATA, string DESCRIPCION)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            ExecuteNonQuery($"INSERT INTO tratamientos (cliente_id, descripcion, fecha, id_trata) VALUES ({CLIENTE_ID}, '{DESCRIPCION}', '{fecha}','{ID_TRATA}');");
        }

    }
}
