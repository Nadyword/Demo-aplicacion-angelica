using HitoriaClinica.DataBase;
using HitoriaClinica.Modelos;
using Microsoft.Data.Sqlite;

namespace HitoriaClinica.Pantallas.Formulario.Logic;

internal class TraerInfoClient : Connection
{ 
    public static Cliente TraerInfoClientById(string id)
    {
        using SqliteDataReader cliente = ExecuteQuery($"SELECT * FROM clientes WHERE id = '{id}'");
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
            Nacimiento = cliente.GetString(8)
        };

        return infoCliente;
    }

    public static Antecedente TraerInfoAntecedentes_personalesById(string id)
    {
        using SqliteDataReader antecedentes_personales = ExecuteQuery($"SELECT * FROM antecedentes_personales WHERE cliente_id = '{id}'");
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

    public static HabitoPsicobio TraerInfoHabitos_psicobiosById(string id)
    {
        using SqliteDataReader habitos_psicobio = ExecuteQuery($"SELECT * FROM habitos_psicobio WHERE cliente_id = '{id}'");
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

    public static ExamenFisico TraerInfoExamen_fisicoById(string id)
    {
        using SqliteDataReader examen_fisico = ExecuteQuery($"SELECT * FROM examen_fisico WHERE cliente_id = '{id}'");
        examen_fisico.Read();

        ExamenFisico examenFisico = new()
        {
            ClienteId = examen_fisico.GetInt32(0),
            Descripcion = examen_fisico.GetString(1)
        };

        return examenFisico;
    }
}
