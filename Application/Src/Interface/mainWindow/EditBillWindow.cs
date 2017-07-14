using Presentation;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace mainWindow
{
    public partial class EditBillWindow : Form
    {
        public EditBillWindow(BillModel model)
        {
            InitializeComponent();
            textBoxDateDueMonth.Text = model.DateOwed.Month.ToString();
            textBoxDateDueDay.Text = model.DateOwed.Day.ToString();
            textBoxDateDueYear.Text = model.DateOwed.Year.ToString();
            textBoxPayment.Text = decimal.Round(model.MonthlyPayment, 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
            Model = model;
            Presenter = new EditBillPresenter();
        }

        #region Properties

        private BillModel Model { get; set; }
        private EditBillPresenter Presenter { get; set; }

        #endregion
        private void BtnAdd(object sender, System.EventArgs e)
        {
            Model.DateOwed = new DateTime(int.Parse(textBoxDateDueYear.Text), int.Parse(textBoxDateDueMonth.Text), int.Parse(textBoxDateDueDay.Text));
            Model.MonthlyPayment = decimal.Parse(textBoxPayment.Text);
            Presenter.EditBill(Model);
            Close();
        }

        #region Helper Methods



        #endregion
    }
}
