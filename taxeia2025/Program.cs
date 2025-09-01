using Peripatos.Core;
using Peripatos_UI;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Database.Connect_PeripatosDB();
            //1. Delete the PlaceImage table.
            //2. Insert images with place name as folder name in Beach/Images.
            //3. run the following method.
           // Database.ONETIME_Insert_PlaceImage("Restaurant");
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