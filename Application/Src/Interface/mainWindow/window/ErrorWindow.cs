using System;
using System.Windows.Forms;

namespace mainWindow.window
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow(string exception)
        {
            InitializeComponent();
            label1.Text = exception;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
