using Domain;
using mainWindow;
using mainWindow.window;
using Presentation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class MainWindow : AbstractWindow
    {
        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
            Presenter = new MainWindowPresenter();
            DisplayedDate = DateTime.Now;
            TotalIncome = 0;
            labelMonth.Text = $@"{DisplayedDate:MMMM}, {DisplayedDate:yyyy}";
            ShowBills();
            ShowIncome();
        }

        #endregion

        #region Properties

        private MainWindowPresenter Presenter { get; set; }
        private DateTime DisplayedDate { get; set; }

        private decimal TotalIncome { get; set; }

        #endregion

        private const string Paid = "Paid";
        private const string NotPaid = "Not paid";

        #region Event Handlers
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            SaveAccountWindow window = new SaveAccountWindow();
            window.FormClosing += Action_FormClosing;
            window.FormClosing += Action_FormClosing;
            window.WindowState = FormWindowState.Normal;
            window.StartPosition = FormStartPosition.Manual;
            window.BringToFront();
            window.Location = new Point(700, 300);
            window.Show();
        }
        private void buttonAddIncome_Click(object sender, EventArgs e)
        {
            IncomeWindow window = new IncomeWindow();
            window.FormClosing += Action_FormClosing;
            window.WindowState = FormWindowState.Normal;
            window.StartPosition = FormStartPosition.Manual;
            window.BringToFront();
            window.Location = new Point(700, 300);
            window.Show();
        }

        private void buttonCalcBudget_Click(object sender, EventArgs e)
        {
            listViewBudget.Items.Clear();
            ShowBudget();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountModel selectedAccount = GetSelectedAccount();
            Presenter.DeleteAccount(selectedAccount);
            lvMain.Items.Clear();
            ShowBills();

        }

        private void buttonDeleteIncome_Click(object sender, EventArgs e)
        {
            PayDayModel model = GetSelectedIncome();
            Presenter.DeleteIncome(model);
            listViewIncome.Items.Clear();
            listViewBudget.Items.Clear();
            labelTotalIncome.Text = "";
            ShowIncome();
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            AccountModel selectedAccount = GetSelectedAccount();
            if (selectedAccount == null)
            {
                return;
            }

            SaveAccountWindow window = new SaveAccountWindow(selectedAccount);
            window.FormClosing += Action_FormClosing;
            window.FormClosing += Action_FormClosing;
            window.WindowState = FormWindowState.Normal;
            window.StartPosition = FormStartPosition.Manual;
            window.BringToFront();
            window.Location = new Point(700, 300);
            window.Show();
        }


        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            DisplayedDate = DisplayedDate.AddMonths(1);
            labelMonth.Text = $@"{DisplayedDate:MMMM}, {DisplayedDate:yyyy}";
            ClearAndReload();
        }

        private void buttonPrevMonth_Click(object sender, EventArgs e)
        {
            DisplayedDate = DisplayedDate.AddMonths(-1);
            labelMonth.Text = string.Format("{0:MMMM}, {1:yyyy}", DisplayedDate, DisplayedDate);
            ClearAndReload();
        }



        private void Action_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearAndReload();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvMain.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            EditBillWindow window = new EditBillWindow(item.Tag as BillModel);
            window.FormClosing += Action_FormClosing;
            window.WindowState = FormWindowState.Normal;
            window.StartPosition = FormStartPosition.Manual;
            window.BringToFront();
            window.Location = new Point(700, 300);
            window.Show();
        }

        private void listViewIncome_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewIncome.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            IncomeWindow window = new IncomeWindow(item.Tag as PayDayModel);
            window.FormClosing += Action_FormClosing;
            window.WindowState = FormWindowState.Normal;
            window.StartPosition = FormStartPosition.Manual;
            window.BringToFront();
            window.Location = new Point(700, 300);
            window.Show();
        }

        #endregion

        #region Helper Methods

        private void ClearAndReload()
        {
            lvMain.Items.Clear();
            listViewIncome.Items.Clear();
            TotalIncome = 0;
            ShowBills();
            ShowIncome();
        }

        private void CreateIncomeRow(PayDayModel model)
        {
            string combinedRowContent = string.Format("{0}, {1}", DollarFormat(model.Amount), model.Date);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = model;
            listViewIncome.Items.Add(item);
            TotalIncome += model.Amount;
        }

        private void CreateBillRow(AccountModel model)
        {
            BillModel billModel = model.Bills.FirstOrDefault(bm => (bm.DateOwed.Month == DisplayedDate.Month) && (bm.DateOwed.Year == DisplayedDate.Year));

            //guard clause - no item
            if (billModel == null)
            {
                return;
            }

            string paidStatus = billModel.Paid ? Paid : NotPaid;
            string accountBalanceDisplay = DollarFormat(model.AccountBalance);
            string monthlyPaymentDisplay = DollarFormat(billModel.MonthlyPayment);

            billModel.ParentId = model.RecordId;
            string combinedRowContent = string.Format("{0},{1},{2},{3},{4},{5}", model.CompanyName, accountBalanceDisplay, monthlyPaymentDisplay, billModel.DateOwed.ToShortDateString(), paidStatus, billModel.ConfirmationNumber);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = billModel;
            lvMain.Items.Add(item);
        }

        private void CreateBudgetRow(DateDecimal budget)
        {
            string combinedRowContent = string.Format("{0}, {1}", budget.Amount, budget.Date);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            listViewBudget.Items.Add(item);
        }

        private void ShowBills()
        {
            AccountModel[] accountModels = Presenter.GetAccounts();
            accountModels.ToList().ForEach(CreateBillRow);
            OrderByDate();

        }

        private void ShowBudget()
        {
            DateDecimal[] budgets = Presenter.GetBudget();
            budgets.ToList().ForEach(CreateBudgetRow);
        }

        private AccountModel GetSelectedAccount()
        {
            // guard clause - no selection
            ListView.SelectedListViewItemCollection selectedItems = lvMain.SelectedItems;
            if (selectedItems.Count == 0)
            {
                return null;
            }

            // guard clause - invalid state
            ListViewItem selectedLvi = selectedItems[0];
            if (selectedLvi == null)
            {
                return null;
            }

            // guard clause - unexpected type
            BillModel selectedRow = selectedLvi.Tag as BillModel;
            if (selectedRow == null)
            {
                return null;
            }

            AccountModel selectedAccount = Presenter.GetAccounts().FirstOrDefault(a => a.RecordId == selectedRow.ParentId);
            if (selectedAccount == null)
            {
                return null;
            }

            return selectedAccount;
        }

        private void OrderByDate()
        {
            List<ListViewItem> items = lvMain.Items.Cast<ListViewItem>().ToList();
            items = items.OrderBy(i => ((BillModel)i.Tag).DateOwed).ToList();
            lvMain.Items.Clear();
            foreach (ListViewItem item in items)
            {
                lvMain.Items.Add(item);
            }
        }

        private PayDayModel GetSelectedIncome()
        {
            // guard clause - no selection
            ListView.SelectedListViewItemCollection selectedItems = listViewIncome.SelectedItems;
            if (selectedItems.Count == 0)
            {
                return null;
            }

            // guard clause - invalid state
            ListViewItem selectedLvi = selectedItems[0];
            if (selectedLvi == null)
            {
                return null;
            }

            // guard clause - unexpected type
            PayDayModel selectedRow = selectedLvi.Tag as PayDayModel;
            if (selectedRow == null)
            {
                return null;
            }

            return selectedRow;
        }

        private void ShowIncome()
        {
            PayDayModel[] model = Presenter.GetPayDaysInMonth(DisplayedDate);
            model.OrderBy(pdm => pdm.Date).Where(pdm => pdm.Date.Month == DisplayedDate.Month && pdm.Date.Year == DisplayedDate.Year).ToList().ForEach(CreateIncomeRow);
            labelTotalIncome.Text = TotalIncome.ToString(CultureInfo.InvariantCulture);
        }

        #endregion

    }
}
