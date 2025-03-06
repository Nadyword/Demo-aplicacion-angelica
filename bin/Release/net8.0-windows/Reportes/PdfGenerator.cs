using DinkToPdf;
using DinkToPdf.Contracts;

namespace HitoriaClinica.Reportes;

public class PdfGenerator(IConverter converter)
{
    private readonly IConverter _converter = converter;

    public void GeneratePdfFromHtmlFile(string htmlFilePath, string outputPath)
    {
        if (!File.Exists(htmlFilePath))
        {
            throw new FileNotFoundException("El archivo HTML no existe.", htmlFilePath);
        }
        if (File.Exists(outputPath))
            File.Delete(outputPath);

        string htmlContent = File.ReadAllText(htmlFilePath);

        HtmlToPdfDocument doc = new()
        {
            GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = DinkToPdf.Orientation.Portrait,
                PaperSize = PaperKind.A4,
            },
            Objects = {
                new ObjectSettings() {
                    PagesCount = true,
                    HtmlContent = htmlContent,
                    WebSettings = { DefaultEncoding = "utf-8", LoadImages = true },
                }
            }
        };

        try
        {
            byte[] pdf = _converter.Convert(doc);
            File.WriteAllBytes(outputPath, pdf);
        }
        finally
        {
            (_converter as IDisposable)?.Dispose();
        }
    }

}

