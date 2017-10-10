using System;
using System.Windows.Forms;
using Assessment2.Solution.MVCO.View;
using Assessment2.Solution.Users;

namespace Assessment2
{
    internal static class Program
    {
        
        //TODO: Closing actions of GUI's, Models, refactoring, cleanup, data sources, indentation & code style.
        //TODO: make logged in user unable to mutate themself
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var handler = new UserHandler();

            if (handler.LoadAllUsers()) {

                try {

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new LoginScreen(handler));

                } catch (Exception e) {
                    
                    Console.WriteLine(@"Unable to display the GUI; most likely due to an unsupported driver.");
                    
                }

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
