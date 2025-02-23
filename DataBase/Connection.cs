using Microsoft.Data.Sqlite;

namespace HitoriaClinica.DataBase
{
    internal class Connection
    {
        private const string connectionString = $"Data Source=C:\\HistoriaClinica\\HitoriaClinica.db";

        #region Simple

        private static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection(connectionString);
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
        #endregion

        #region Async

        private static async Task<SqliteConnection> AsyncGetConnection()
        {
            var connection = new SqliteConnection(connectionString);
            await connection.OpenAsync();
            return connection;
        }

        protected static async Task AsyncExecuteNonQuery(string sql)
        {
            using var connection = await AsyncGetConnection();
            using var command = new SqliteCommand(sql, connection);
            await command.ExecuteNonQueryAsync();
            connection.Close();
        }

        protected static async Task<SqliteDataReader> AsyncExecuteQuery(string sql)
        {
            var connection = await AsyncGetConnection();
            var command = new SqliteCommand(sql, connection);
            return await command.ExecuteReaderAsync(System.Data.CommandBehavior.CloseConnection);
        }

        #endregion
    }
}