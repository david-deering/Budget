using Budget.window;
using mainWindow.window;
using Presentation;
using Presentation.Presenter;
using System;
using System.Drawing;
using System.Globalization;

namespace Budget
{
    public partial class IncomeWindow : AbstractWindow
    {
        public IncomeWindow()
        {
            Initialize();
        }

        public IncomeWindow(PayDayModel model)
        {
            Initialize(model);
        }

        #region Properties

        private PayDayModel Model { get; set; }
        private PayDayPresenter Presenter { get; set; }

        #endregion

        #region eventHandlers

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Model.Date = DateTime.Parse(textBoxDateDue.Text);
            Model.Amount = decimal.Parse(textBoxAmount.Text);

            try
            {
                Presenter.SavePayDay(Model);
            }
            catch (Exception ex)
            {
                ErrorWindow window = new ErrorWindow(ex.Message);
                ShowWindow(window);
            }

            Close();
        }

        private void textBoxDateDue_TextChanged(object sender, EventArgs e)
        {
            ValidateDate(textBoxDateDue, buttonSave);
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            ValidateDecimal(textBoxAmount, buttonSave);
        }

        #endregion

        #region Helper Methods
        private void Initialize()
        {
            InitializeComponent();
            textBoxAmount.BackColor = Color.Tomato;
            textBoxDateDue.BackColor = Color.Tomato;
            Model = new PayDayModel();
            Presenter = new PayDayPresenter();
        }

        private void Initialize(PayDayModel model)
        {
            Initialize();
            Model = model;
            textBoxDateDue.Text = Model.Date.ToShortDateString();
            textBoxAmount.Text = decimal.Round(model.Amount, 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
        }
        #endregion

    }
}
