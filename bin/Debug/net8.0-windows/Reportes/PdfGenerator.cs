    using DinkToPdf;
    using DinkToPdf.Contracts;
    using System;
    using System.IO;

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

            string htmlContent = File.ReadAllText(htmlFilePath);

            var doc = new HtmlToPdfDocument()
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
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                        FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Footer" }
                    }
                }
            };

            byte[] pdf = _converter.Convert(doc);
            File.WriteAllBytes(outputPath, pdf);
        }
    }

