using System;
using System.Windows.Forms;
using Assessment2.Solution.Users;
using Assessment2.Solution.Views;

namespace Assessment2
{
    internal static class Program
    {
        
        //TODO: Closing actions of GUI's, Models, refactoring, cleanup, data sources, indentation & code style.
        //TODO: make logged in user unable to mutate themself
        //TODO: formatting of integers, numbers, etc
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                
                Init();

            } catch (Exception e) {
                
                Console.WriteLine($@"Uncaught exception during initiation: '{e.Message}'.");
                
            }
        }

        private static void Init() {
            var handler = new UserHandler();

            if (handler.LoadAllUsers()) {

                try {

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new LoginScreen(handler));

                } catch (Exception e) {
                    
                    Console.WriteLine($@"Exception: {e.Message}");
                    Console.WriteLine(@"Unable to display the GUI; most likely due to a lack of support for windows forms.");
                    
                }

            } else {

                MessageBox.Show(@"The program was unable to load all users.");
            }
        }
    }
}
