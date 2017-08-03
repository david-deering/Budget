using mainWindow.window;
using Presentation;
using Presentation.Presenter;
using System;

namespace mainWindow
{
    public partial class IncomeWindow : AbstractWindow
    {
        public IncomeWindow()
        {
            Initialize();
            Model = new PayDayModel();
        }

        public IncomeWindow(PayDayModel model)
        {
            Initialize();
            Model = model;
        }
        #region Properties

        private PayDayModel Model { get; }
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
            Presenter.SavePayDay(Model);
            Close();
        }

        private void textBoxDateDue_TextChanged(object sender, EventArgs e)
        {
            ValidateDate(textBoxDateDue, buttonSave);
        }

        #endregion

        #region Helper Methods
        private void Initialize()
        {
            InitializeComponent();
            Presenter = new PayDayPresenter();
        }
        #endregion

    }
}
