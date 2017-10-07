﻿using System;
using System.Windows.Forms;
using Assessment2.Solution.MVCO.View;
using Assessment2.Solution.Users;

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

            var handler = new UserHandler();

            if (handler.LoadAllUsers()) {
                var login = new LoginScreen(handler);

                Application.Run(login);

                Application.Run(new RegistrationScreen(handler));
                Application.Run(new UserListScreen(handler));
                
            } else {

                MessageBox.Show(@"An error occured when attempting to load all users.");

            }
        }
    }
}
