using System;
using System.Windows.Forms;

namespace Assessment2
{
    internal static class Program
    {
        
        //TODO: Models, refactoring, cleanup, data sources, indentation & code style.
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var login = new LoginScreen();
            
            Application.Run(login);
            
            Application.Run(new RegistrationScreen(login.Handler));
            Application.Run(new UserListScreen(login.Handler));
        }
    }
}
