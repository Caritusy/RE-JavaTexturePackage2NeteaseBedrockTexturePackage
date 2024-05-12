using System.Runtime.InteropServices;

namespace RE_JavaTexturePackage2NBTP
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}