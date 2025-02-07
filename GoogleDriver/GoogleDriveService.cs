using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using HitoriaClinica.DataBase;

namespace HitoriaClinica.GoogleDriver;

public class GoogleDriveService
{
    public static DriveService GetDriveService()
    {
        string[] Scopes = [DriveService.Scope.DriveFile, DriveService.Scope.Drive];
        string ApplicationName = "HistoriaClinica";

        UserCredential credential;
        string path = AppDomain.CurrentDomain.BaseDirectory + "Recursos\\credentials.json";

        using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            string credPath = "token.json";
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;
        }

        return new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });
    }

    public static void UploadFile(string filePath)
    {
        var service = GoogleDriveService.GetDriveService();

        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
        {
            Name = Path.GetFileName(filePath)
        };

        FilesResource.CreateMediaUpload request;
        using (var stream = new FileStream(filePath, FileMode.Open))
        {
            request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
            request.Fields = "id";
            request.Upload();
        }

        _ = request.ResponseBody;
    }

    public static void DownloadFile(string fileName, string savePath)
    {
        var service = GoogleDriveService.GetDriveService();
        var request = service.Files.Get(BuscarArchivoByName(fileName));

        using var stream = new FileStream(savePath, FileMode.Create, FileAccess.Write);
        request.Download(stream);
    }


    public static void DeleteFile(string fileName)
    {
        var service = GoogleDriveService.GetDriveService();
        service.Files.Delete(BuscarArchivoByName(fileName)).Execute();
    }

    public static void SincronisarBD()
    {
        string dbPath = AppDomain.CurrentDomain.BaseDirectory;
        Connection.NewBD =  DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + ".db";
        DownloadFile("HitoriaClinica.db", Path.Combine(dbPath, Connection.NewBD));
    }

    public static void ActualizarBD()
    {
        DeleteFile("HitoriaClinica.db");
        string dbPath = AppDomain.CurrentDomain.BaseDirectory;
        UploadFile(Path.Combine(dbPath, "HitoriaClinica.db"));
    }

    private static string BuscarArchivoByName(string fileName)
    {
        var service = GoogleDriveService.GetDriveService();

        FilesResource.ListRequest request = service.Files.List();
        request.Q = $"name = '{fileName}' and trashed = false";
        request.Fields = "files(id, name)";

        FileList result = request.Execute();
        if (result.Files.Count > 0)
        {
            return result.Files[0].Id;
        }

        return "";
    }

}