using System;
using System.Windows.Forms;
using Assessment2.Solution.MVCO.View;
using Assessment2.Solution.Users;

namespace Assessment2
{
    internal static class Program
    {
        
        //TODO: Closing actions of GUI's, Models, refactoring, cleanup, data sources, indentation & code style.
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var handler = new UserHandler();

            if (handler.LoadAllUsers()) {
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new LoginScreen(handler));
                
            } else {
                
                const string error = "The program was unable to load all users.";

                try {

                    MessageBox.Show(error);

                } catch (Exception e) {
                    
                    Console.WriteLine(error);
                    
                }
            }
        }
    }
}
