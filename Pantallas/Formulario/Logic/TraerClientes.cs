using HitoriaClinica.DataBase;
using Microsoft.Data.Sqlite;

namespace HitoriaClinica.Pantallas.Formulario.Logic;

internal class TraerClientes : Connection
{
    public static async Task<List<Cliente>> TraerAllClientes()
    {
        var clientes = new List<Cliente>();
        using (SqliteDataReader reader = await Connection.AsyncExecuteQuery("SELECT * FROM clientes"))
        {
            while (reader.Read())
            {
                Cliente cliente = new()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Cedula = reader.GetString(3)
                };
                clientes.Add(cliente);
            }
        }
        return clientes;
    }

    public static List<Cliente> TraerCliente(string buscar)
    {
        var clientes = new List<Cliente>();
        using (SqliteDataReader reader = Connection.ExecuteQuery($"SELECT * FROM clientes WHERE cedula = '%{buscar}%' OR nombre = '%{buscar}%' OR apellido = '%{buscar}%'"))
        {
            while (reader.Read())
            {
                Cliente cliente = new()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Cedula = reader.GetString(3)
                };
                clientes.Add(cliente);
            }
        }
        return clientes;
    }

    public class Cliente
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Cedula { get; set; }
    }
}
