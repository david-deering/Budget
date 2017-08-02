using Presentation;
using Presentation.Presenter;
using System;
using System.Windows.Forms;

namespace mainWindow
{
    public partial class IncomeWindow : Form
    {
        public IncomeWindow()
        {
            InitializeComponent();
            Presenter = new PayDayPresenter();
            Model = new PayDayModel();
        }

        public IncomeWindow(PayDayModel model)
        {
            InitializeComponent();
            Presenter = new PayDayPresenter();
            Model = model;
        }
        #region Properties

        private PayDayModel Model { get; }

        private PayDayPresenter Presenter { get; set; }

        #endregion

        #region eventHandlers
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Model.Date = DateTime.Parse(textBoxDateDue.Text);
            Model.Amount = decimal.Parse(textBoxAmount.Text);
            Presenter.SavePayDay(Model);
            Close();
        }

        #endregion

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
