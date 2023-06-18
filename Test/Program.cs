using System.Runtime.CompilerServices;

namespace Test
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
            ApplicationConfiguration.Initialize();
            Forms forms = new Forms();
            Application.Run(forms);
            if (forms.Check) {
                Application.Run(new Form1()); }
        }
    }
}