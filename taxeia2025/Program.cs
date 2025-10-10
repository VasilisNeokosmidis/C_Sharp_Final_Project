using Peripatos.Core;
using Peripatos_UI;
using System.Globalization;

namespace Peripatos_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Κώδικας για ορθή λειτουργία των ελληνικών
            Thread.CurrentThread.CurrentCulture = new CultureInfo("el-GR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("el-GR");
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Database.Connect_PeripatosDB();
            //Database.ONETIME_Insert_PlaceImage("Beaches");
            //Database.ONETIME_Insert_PlaceImage("Restaurant");
            //Database.ONETIME_Insert_PlaceImage("Sight");
            AppList_Manager.Initialize_Lists();

            ApplicationConfiguration.Initialize();
            
            using (var loginForm = new Login_Form())
            {
                // Είχαμε βάλει τη main form ως parent, για να μην αλλάξει η λογική βάζουμε να εμφανίζεται πρώτα η login form.
                loginForm.ShowDialog();
                UserProfile user = loginForm.AuthenticatedUser ?? UserProfile.Guest();
                var session = new SessionContext(user);
                Application.Run(new Main_Form(session));
            }
        }
    }
}