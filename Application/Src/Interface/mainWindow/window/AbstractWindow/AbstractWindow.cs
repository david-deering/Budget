using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budget.window
{
    public class AbstractWindow : Form
    {

        #region Constructors

        protected AbstractWindow()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Protected Methods
        protected string DollarFormat(decimal number)
        {
            return string.Format("{0}{1}", "$", decimal.Round(number, 2, MidpointRounding.AwayFromZero));
        }

        protected void ValidateDate(TextBox textBox, Button buttonSave)
        {

            bool result = Validator.ValidateDate(textBox.Text);
            ShowValidationResult(result, textBox, buttonSave);

        }

        protected void ValidateDecimal(TextBox textBox, Button buttonSave)
        {
            bool result = Validator.ValidateDecimal(textBox.Text);
            ShowValidationResult(result, textBox, buttonSave);
        }

        protected void ValidateText(TextBox textBox, Button buttonSave)
        {
            bool result = Validator.ValidateString(textBox.Text);
            ShowValidationResult(result, textBox, buttonSave);
        }
        protected void ShowWindow(Form window)
        {
            window.WindowState = FormWindowState.Normal;
            window.StartPosition = FormStartPosition.Manual;
            window.BringToFront();
            window.Location = new Point(700, 300);
            window.Show();
        }


        #endregion

        #region Helper Methods

        private void ShowValidationResult(bool result, TextBox textBox, Button button)
        {
            if (!result)
            {
                textBox.BackColor = Color.Tomato;
                button.Enabled = false;
                return;
            }

            textBox.ResetBackColor();
            button.Enabled = true;
        }

        #endregion

    }
}
