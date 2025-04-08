using Microsoft.Extensions.DependencyInjection;

namespace quickmimo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddRecipeNoteBookDataService();
            //appliquer les migrations de demarrage 
            services.ApplyMigrationsForRecipeNoteBookDataService();
            Application.Run(new login());
        }
    }
}