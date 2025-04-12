using System;
using ITISystemEF.Context;

namespace ITISystemEF
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

            var db = new MyContext();
            ApplicationConfiguration.Initialize();
            Application.Run(new Start_Form());
        }
    }
}