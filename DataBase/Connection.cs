using Microsoft.Data.Sqlite;

namespace HitoriaClinica.DataBase
{
    internal class Connection
    {
        private static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection("Data Source=HitoriaClinica.db");
            connection.Open();
            return connection;
        }

        protected static void ExecuteNonQuery(string sql)
        {
            using var connection = GetConnection();
            using var command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        protected static SqliteDataReader ExecuteQuery(string sql)
        {
            var connection = GetConnection();
            var command = new SqliteCommand(sql, connection);
            return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}