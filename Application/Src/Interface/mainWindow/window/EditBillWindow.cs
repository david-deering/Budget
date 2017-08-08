using Budget.window;
using mainWindow.window;
using Presentation;
using System;
using System.Globalization;

namespace Budget
{
    public partial class EditBillWindow : AbstractWindow
    {
        public EditBillWindow(BillModel model)
        {
            InitializeComponent();
            textBoxConfirmationNumber.Text = model.ConfirmationNumber;
            textBoxDateDue.Text = model.DateOwed.ToShortDateString();
            textBoxPayment.Text = decimal.Round(model.MonthlyPayment, 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
            Model = model;
            checkBoxPaid.Checked = model.Paid;

            Presenter = new EditBillPresenter();
        }

        #region Properties

        private BillModel Model { get; set; }
        private EditBillPresenter Presenter { get; set; }

        #endregion

        private void BtnAdd(object sender, System.EventArgs e)
        {
            Model.ConfirmationNumber = textBoxConfirmationNumber.Text;
            Model.DateOwed = DateTime.Parse(textBoxDateDue.Text);
            Model.MonthlyPayment = decimal.Parse(textBoxPayment.Text);
            Model.Paid = checkBoxPaid.Checked;

            try
            {
                Presenter.EditBill(Model);
            }
            catch (Exception ex)
            {
                ErrorWindow window = new ErrorWindow(ex.Message);
                ShowWindow(window);
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxDateDue_TextChanged(object sender, EventArgs e)
        {
            ValidateDate(textBoxDateDue, buttonSave);
        }

        private void textBoxPayment_TextChanged(object sender, EventArgs e)
        {
            ValidateDecimal(textBoxPayment, buttonSave);
        }
    }
}
