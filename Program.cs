using System.Data;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using quickmimo.context;
using quickmimo.TaskForms;
using Calendar = quickmimo.Calendrier.Calendar;

namespace quickmimo
{
    internal static class Program
    {
        public static DBMimoContext DbContext = new DBMimoContext();

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
            services.AddMimoNoteBookDataService();
            //appliquer les migrations de demarrage 
            services.ApplyMigrationsForMimoNoteBookDataService();
            Application.Run(new login());
        }
    }
}