using Microsoft.Data.Sqlite;
using SQLite = HitoriaClinica.DataBase.Connection;

namespace HitoriaClinica.Pantallas.Formulario.Logic;

internal class AgregarTratamiento
{
    public static List<Tratamiento> TraerTratamientos()
    {
        var tratamientos = new List<Tratamiento>();

        using (SqliteDataReader reader = SQLite.ExecuteQuery("SELECT Id, Descripcion FROM Tratamientos"))
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

    public class Tratamiento
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
    }
}
