using System;
using System.Drawing;
using System.Windows.Forms;

namespace mainWindow.window
{
    public class AbstractWindow : Form
    {

        #region Constructors

        protected AbstractWindow()
        {
            DateInputValidator = new DateInputValidator();
        }

        #endregion

        #region Properties
        private DateInputValidator DateInputValidator { get; set; }

        #endregion

        #region Protected Methods
        protected string DollarFormat(decimal number)
        {
            return string.Format("{0}{1}", "$", decimal.Round(number, 2, MidpointRounding.AwayFromZero));
        }

        protected void ValidateDate(TextBox textBoxDate, Button buttonSave)
        {
            if (!DateInputValidator.ValidateDate(textBoxDate.Text))
            {
                textBoxDate.BackColor = Color.Tomato;
                buttonSave.Enabled = false;
                return;
            }

            textBoxDate.ResetBackColor();
            buttonSave.Enabled = true;
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
