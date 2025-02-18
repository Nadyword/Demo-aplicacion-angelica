using HitoriaClinica.GoogleDriver;
using Microsoft.Data.Sqlite;

namespace HitoriaClinica.DataBase;

internal class Connection
{
    #region Variables de clase

    private readonly static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HitoriaClinica.db") ?? "HitoriaClinica.db";
    public static string NewBD { get; set; } = "";

    #endregion

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

    #region Sincronizacion de la base de datos en google drive

    public static void SincronizarDB()
    {
        NewBD = GoogleDriveService.DownloadBD();
        GC.Collect();
        GC.WaitForPendingFinalizers();

        using var backupConnection = new SqliteConnection($"Data Source={NewBD};Pooling=False");
        backupConnection.Open();

        using var mainConnection = new SqliteConnection($"Data Source={dbPath};Pooling=False");
        mainConnection.Open();

        backupConnection.BackupDatabase(mainConnection);
        backupConnection.Close();
        mainConnection.Close();
    }

        #endregion
}