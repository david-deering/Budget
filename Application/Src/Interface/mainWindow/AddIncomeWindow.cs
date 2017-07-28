using Presentation;
using Presentation.Presenter;
using System;
using System.Windows.Forms;

namespace mainWindow
{
    public partial class AddIncomeWindow : Form
    {
        public AddIncomeWindow()
        {
            InitializeComponent();
            Presenter = new PayDayPresenter();
            Model = new PayDayModel();
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
            Presenter.AddPayDay(Model);
            Close();
        }

        #endregion
    }
}
