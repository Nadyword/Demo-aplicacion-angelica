using HitoriaClinica.DataBase;
using Microsoft.Data.Sqlite;

namespace HitoriaClinica.Pantallas.Formulario.Logic;

internal class AgregarTratamiento : Connection
{
    public static List<Tratamiento> TraerTratamientos()
    {
        var tratamientos = new List<Tratamiento>();

        using (SqliteDataReader reader = Connection.ExecuteQuery("SELECT Id, Descripcion FROM tratamientos_combo WHERE activo = 1 ORDER BY orden"))
        {
            while (reader.Read())
            {
                Tratamiento tratamiento = new()
                {
                    Id = reader.GetInt32(0),
                    Descripcion = reader.GetString(1)
                };
                tratamientos.Add(tratamiento);
            }
        }

        return tratamientos;
    }

    public static List<Tratamiento> TraerTratamientosWithOrder()
    {
        var tratamientos = new List<Tratamiento>();

        using (SqliteDataReader reader = Connection.ExecuteQuery("SELECT Id, Descripcion, orden, activo FROM tratamientos_combo ORDER BY orden"))
        {
            while (reader.Read())
            {
                Tratamiento tratamiento = new()
                {
                    Id = reader.GetInt32(0),
                    Descripcion = reader.GetString(1),
                    Orden = reader.GetString(2),
                    Activo = reader.GetBoolean(3)
                };
                tratamientos.Add(tratamiento);
            }
        }

        return tratamientos;
    }

    public class Tratamiento
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
        public string? Orden { get; set; }
        public bool Activo { get; set; }
    }
}
