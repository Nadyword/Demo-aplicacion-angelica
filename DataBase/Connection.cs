using Microsoft.Data.Sqlite;

namespace HitoriaClinica.DataBase
{
    internal class Connection
    {

        private readonly static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HitoriaClinica.db") ?? "HitoriaClinica.db";
        public static string NewBD { get; set; } = "";

        #region Simple

        private static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection($"Data Source={dbPath};Pooling=False");
            connection.Open();
            return connection;
        }

        public static SqliteConnection GetConnection(string dbPath)
        {
            var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();
            connection.Close();
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
            var connection = new SqliteConnection($"Data Source={dbPath};Pooling=False");
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


        public static void CopyDatabaseContent()
        {
            using var connection = new SqliteConnection($"Data Source={NewBD};Pooling=False");
            connection.Open();

            using var command = connection.CreateCommand();

            try
            {
                command.CommandText = "PRAGMA foreign_keys = OFF;";
                command.ExecuteNonQuery();

                command.CommandText = @"
                    ATTACH DATABASE '" + dbPath + @"' AS OrigenDB;
                    SELECT 'DELETE FROM ' || name || ';' FROM sqlite_master WHERE type='table';
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string deleteQuery = reader.GetString(0);
                        new SqliteCommand(deleteQuery, connection).ExecuteNonQuery();
                    }
                }

                command.CommandText = @"
                    ATTACH DATABASE '" + dbPath + @"' AS OrigenDB;
                    SELECT 'INSERT INTO ' || name || ' SELECT * FROM OrigenDB.' || name || ';' 
                    FROM sqlite_master WHERE type='table';
                ";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string insertQuery = reader.GetString(0);
                        new SqliteCommand(insertQuery, connection).ExecuteNonQuery();
                    }
                }

                // 🔹 Restaurar claves foráneas
                command.CommandText = "PRAGMA foreign_keys = ON;";
                command.ExecuteNonQuery();

                Console.WriteLine("✅ Datos copiados con éxito de Origen.db a Destino.db");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }

}