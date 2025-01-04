namespace HitoriaClinica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
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