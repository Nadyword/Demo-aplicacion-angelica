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
    }
}
