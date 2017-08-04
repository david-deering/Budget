using Budget.window;
using Presentation;
using System;
using System.Globalization;

namespace Budget
{
    public partial class SaveAccountWindow : AbstractWindow
    {
        #region Constructors

        public SaveAccountWindow()
        {
            InitializeComponent();
            tableLayoutPanelAddAccount.Visible = true;
            buttonDelete.Hide();
            EditMode = false;
            Presenter = new AccountPresenter();
        }

        public SaveAccountWindow(AccountModel model)
        {
            InitializeComponent();
            EditMode = true;
            Presenter = new AccountPresenter();
            decimal balance = decimal.Round(model.AccountBalance, 2, MidpointRounding.AwayFromZero);
            decimal interest = decimal.Round(model.InterestRate, 2, MidpointRounding.AwayFromZero);

            textBoxBalance.Text = balance.ToString(CultureInfo.InvariantCulture);
            textBoxInterestRate.Text = interest.ToString(CultureInfo.InvariantCulture);
            textBoxName.Text = model.CompanyName;
            tableLayoutPanelAccount.Tag = model;
        }

        #endregion

        #region Properties

        private bool EditMode { get; set; }
        private AccountPresenter Presenter { get; set; }

        #endregion

        #region Public Methods



        #endregion


        #region Event Handlers


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                AccountModel accountModel = tableLayoutPanelAccount.Tag as AccountModel;
                accountModel.AccountBalance = decimal.Parse(textBoxBalance.Text);
                accountModel.CompanyName = textBoxName.Text;
                accountModel.InterestRate = decimal.Parse(textBoxInterestRate.Text);
                Presenter.EditAccount(accountModel);
                Close();
                return;
            }

            AddAccountModel model = new AddAccountModel();
            model.AccountBalance = decimal.Parse(textBoxBalance.Text);
            model.CompanyName = textBoxName.Text;
            model.InterestRate = decimal.Parse(textBoxInterestRate.Text);
            model.FirstDueDate = DateTime.Parse(textBoxFirstDueDate.Text);
            model.AmountDue = decimal.Parse(textBoxAmountDue.Text);

            Presenter.SaveAccount(model);
            Close();
        }

        private void textBoxFirstDueDate_TextChanged(object sender, EventArgs e)
        {
            ValidateDate(textBoxFirstDueDate, buttonSave);
        }
        #endregion


    }
}
