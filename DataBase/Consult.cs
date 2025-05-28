using HitoriaClinica.Modelos;
using Microsoft.Data.Sqlite;

namespace HitoriaClinica.DataBase
{
    internal class Consult : Connection
    {
        public static SqliteDataReader ExistClient(string cedula)
        {
            return ExecuteQuery($"SELECT id FROM clientes WHERE cedula = '{cedula}'");
        }

        public static int IdClient(string cedula)
        {
            SqliteDataReader reader = ExecuteQuery($"SELECT * FROM clientes WHERE cedula = '{cedula}'");
            reader.Read();
            int id = reader.GetInt32(0);
            reader.Close();
            return id;
        }

        public static async Task<Cliente> AsyncTraerInfoClientById(int id)
        {
            using SqliteDataReader cliente = await AsyncExecuteQuery($"SELECT * FROM clientes WHERE id = {id}");
            cliente.Read();

            Cliente infoCliente = new()
            {
                Id = cliente.GetInt32(0),
                Nombre = cliente.GetString(1),
                Apellido = cliente.GetString(2),
                Cedula = cliente.GetString(3),
                Telefono = cliente.GetInt64(4),
                Sexo = cliente.GetInt32(5),
                Direccion = cliente.GetString(6),
                Ocupacion = cliente.GetString(7),
                Nacimiento = cliente.GetString(8),
                Foto = cliente.GetString(9)
            };

            return infoCliente;
        }

        public static async Task<Antecedente> AsyncTraerInfoAntecedentes_personalesById(string id)
        {
            using SqliteDataReader antecedentes_personales = await AsyncExecuteQuery($"SELECT * FROM antecedentes_personales WHERE cliente_id = '{id}'");
            antecedentes_personales.Read();

            Antecedente antecedente = new()
            {
                ClienteId = antecedentes_personales.GetInt32(0),
                Enfermedad = antecedentes_personales.GetString(1),
                AlergiaMedicamentos = antecedentes_personales.GetString(2),
                AlergiaAlimentos = antecedentes_personales.GetString(3),
                Cirugias = antecedentes_personales.GetString(4),
                Tratamientos = antecedentes_personales.GetString(5),
                Biopsias = antecedentes_personales.GetString(6)
            };

            return antecedente;
        }

        public static async Task<HabitoPsicobio> AsyncTraerInfoHabitos_psicobiosById(string id)
        {
            using SqliteDataReader habitos_psicobio = await AsyncExecuteQuery($"SELECT * FROM habitos_psicobio WHERE cliente_id = '{id}'");
            habitos_psicobio.Read();

            HabitoPsicobio habitoPsicobio = new()
            {
                ClienteId = habitos_psicobio.GetInt32(0),
                Tabaquismo = habitos_psicobio.GetString(1),
                ActividadFisica = habitos_psicobio.GetString(2),
                Alcoholismo = habitos_psicobio.GetString(3),
                Otros = habitos_psicobio.GetString(4)
            };

            return habitoPsicobio;
        }

        public static async Task<ExamenFisico> AsyncTraerInfoExamen_fisicoById(string id)
        {
            using SqliteDataReader examen_fisico = await AsyncExecuteQuery($"SELECT * FROM examen_fisico WHERE cliente_id = '{id}'");
            examen_fisico.Read();

            ExamenFisico examenFisico = new()
            {
                ClienteId = examen_fisico.GetInt32(0),
                Descripcion = examen_fisico.GetString(1)
            };

            return examenFisico;
        }

        public static async Task<HistorialTratamiento> AsyncTraerInfoHistorial_tratamientoById(string id)
        {
            using SqliteDataReader historial_tratamiento = await AsyncExecuteQuery($"SELECT * FROM historial_tratamiento WHERE cliente_id = '{id}'");
            historial_tratamiento.Read();
            if (historial_tratamiento.HasRows)
            {
                HistorialTratamiento historialTratamiento = new()
                {
                    ClienteId = historial_tratamiento.GetInt32(0),
                    Descripcion = historial_tratamiento.GetString(1)
                };
                return historialTratamiento;
            }

            return new HistorialTratamiento
            {
                ClienteId = 0,
                Descripcion = ""
            };
        }
    }
}
