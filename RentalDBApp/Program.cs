﻿using System;
using System.Windows.Forms;

namespace RentalDBApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new MovieAccessForm());
           Application.Run(new MainMenuForm());
            //Application.Run(new LoginForm());
            //Application.Run(new SignUpForm());
            
        }
    }
}
