using Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainWindow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceEnvironment.Singleton.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow MW = new MainWindow();
            int width = SystemInformation.VirtualScreen.Width;
            int height = SystemInformation.VirtualScreen.Height;
            int windowWidth = 1310;
            int windowHeight = 760;
            int pointX = width / 3;
            int pointY = height / 3;
            MW.DesktopLocation = new Point(pointX, pointY);
            MW.Size = new Size(windowWidth, windowHeight);
            Application.Run(MW);
        }
    }
}
