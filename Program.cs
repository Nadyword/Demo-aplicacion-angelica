namespace HitoriaClinica
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                if (Directory.Exists("C:\\HistoriaClinica"))
                {
                    Directory.Delete("C:\\HistoriaClinica",true);
                }

                Directory.CreateDirectory("C:\\HistoriaClinica");

                ApplicationConfiguration.Initialize();
                Application.Run(new FromInicio());
            }
            catch (Exception ex)
            {
                MessageBox.Show( "¡Algo salio mal! mandale un print a Samuel de este error " + ex.Message,"Se produjo un error");
            }
        }
    }
}