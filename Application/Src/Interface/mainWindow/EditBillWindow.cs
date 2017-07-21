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
            textBoxDateDue.Text = model.DateOwed.ToShortDateString();
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
            Model.DateOwed = DateTime.Parse(textBoxDateDue.Text);
            Model.MonthlyPayment = decimal.Parse(textBoxPayment.Text);
            Presenter.EditBill(Model);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Helper Methods



        #endregion
    }
}
