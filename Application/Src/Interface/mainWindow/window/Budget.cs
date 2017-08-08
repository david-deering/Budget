using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Budget;
using Budget.window;
using Domain;
using Presentation;

namespace mainWindow.window
{
    public partial class Budget : AbstractWindow
    {
        #region Constructors

        public Budget()
        {
            InitializeComponent();
            Presenter = new MainWindowPresenter();
            DisplayedDate = DateTime.Now;
            TotalIncome = 0;
            labelMonth.Text = string.Format("{0}, {1}", DisplayedDate.ToString("MMMM"), DisplayedDate.ToString("yyyy"));
            GenerateBillsIfNewMonth();
            ShowBills();
            ShowIncome();
            ShowAccounts();
        }

        #endregion

        #region Properties

        private DateTime DisplayedDate { get; set; }
        private MainWindowPresenter Presenter { get; set; }
        private decimal TotalIncome { get; set; }

        #endregion

        private const string Paid = "Paid";
        private const string NotPaid = "Not paid";

        #region Event Handlers

        private void Action_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearAndReload();
        }

        private void activateAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountModel model = GetSelectedAccount(listViewAccounts);
            model.IsActive = true;
            Presenter.UpdateAccount(model);
            ClearAndReload();
        }

        private void addAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAccountWindow window = new SaveAccountWindow();
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeWindow window = new IncomeWindow();
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            SaveAccountWindow window = new SaveAccountWindow();
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void buttonAddIncome_Click(object sender, EventArgs e)
        {
            IncomeWindow window = new IncomeWindow();
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void buttonAddIncome_Click_1(object sender, EventArgs e)
        {
            IncomeWindow window = new IncomeWindow();
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void buttonCalcBudget_Click(object sender, EventArgs e)
        {
            listViewBudget.Items.Clear();
            ShowBudget();
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountModel model = GetSelectedAccount(listViewAccounts);
            if (model == null)
            {
                return;
            }

            ConfirmDeleteWindow window = new ConfirmDeleteWindow(model);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);

        }

        private void buttonDeleteIncome_Click(object sender, EventArgs e)
        {
            PayDayModel model = GetSelectedIncome(listViewConfigIncome);
            if (model == null)
            {
                return;
            }

            ConfirmDeleteWindow window = new ConfirmDeleteWindow(model);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            AccountModel model = GetSelectedAccount(listViewAccounts);
            if (model == null)
            {
                return;
            }

            SaveAccountWindow window = new SaveAccountWindow(model);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void buttonEditIncome_Click(object sender, EventArgs e)
        {
            PayDayModel model = GetSelectedIncome(listViewConfigIncome);
            if (model == null)
            {
                return;
            }

            IncomeWindow window = new IncomeWindow(model);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
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

        private void buttonSetActive_Click(object sender, EventArgs e)
        {
            AccountModel model = GetSelectedAccount(listViewAccounts);
            if (model == null)
            {
                return;
            }

            model.IsActive = !model.IsActive;
            Presenter.UpdateAccount(model);
            ClearAndReload();
        }

        private void confirmDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountModel model = GetSelectedAccount(listViewAccounts);
            Presenter.DeleteAccount(model.RecordId);
            ClearAndReload();
        }

        private void confirmDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PayDayModel model = GetSelectedIncome(listViewIncome);
            Presenter.DeleteIncome(model.RecordId);
            listViewIncome.Items.Clear();
            listViewBudget.Items.Clear();
            labelTotalIncome.Text = "";
            ShowIncome();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvMain.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            EditBillWindow window = new EditBillWindow(item.Tag as BillModel);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void listViewAccount_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int columnClicked = e.Column;
            switch (columnClicked)
            {
                case 0:
                    SortAccountsByCompanyName();
                    break;
                case 1:
                    SortAccountsByAccountBalance();
                    break;
                case 2:
                    SortAccountsShowAllActiveAccountsOnTop();
                    break;
            }
        }

        private void listViewAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewHitTestInfo info = listViewAccounts.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            SaveAccountWindow window = new SaveAccountWindow(item.Tag as AccountModel);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void listViewAccounts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            ListViewHitTestInfo info = listViewAccounts.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item == null)
            {
                contextMenuStrip1Account.Items[0].Visible = true;
                contextMenuStrip1Account.Items[1].Visible = false;
                contextMenuStrip1Account.Items[2].Visible = false;
                contextMenuStrip1Account.Items[3].Visible = false;
            }
            else
            {
                contextMenuStrip1Account.Items[0].Visible = false;
                contextMenuStrip1Account.Items[1].Visible = true;

                AccountModel model = item.Tag as AccountModel;
                if (model.IsActive)
                {
                    contextMenuStrip1Account.Items[2].Visible = true;
                    contextMenuStrip1Account.Items[3].Visible = false;
                }
                else
                {
                    contextMenuStrip1Account.Items[2].Visible = false;
                    contextMenuStrip1Account.Items[3].Visible = true;
                }
            }

            contextMenuStrip1Account.Show(Cursor.Position);
        }

        private void listViewIncome_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewIncome.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            IncomeWindow window = new IncomeWindow(item.Tag as PayDayModel);
            window.FormClosing += Action_FormClosing;
            ShowWindow(window);
        }

        private void listViewIncome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            ListViewHitTestInfo info = listViewIncome.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item == null)
            {
                contextMenuStripIncome.Items[0].Visible = true;
                contextMenuStripIncome.Items[1].Visible = false;
            }
            else
            {
                contextMenuStripIncome.Items[0].Visible = false;
                contextMenuStripIncome.Items[1].Visible = true;
            }

            contextMenuStripIncome.Show(Cursor.Position);
        }

        private void toolStripMenuItem1Deactivate_Click(object sender, EventArgs e)
        {
            AccountModel model = GetSelectedAccount(listViewAccounts);
            model.IsActive = false;
            Presenter.UpdateAccount(model);
            ClearAndReload();
        }

        #endregion

        #region Helper Methods

        private void ClearAndReload()
        {
            lvMain.Items.Clear();
            listViewIncome.Items.Clear();
            listViewConfigIncome.Items.Clear();
            listViewAccounts.Items.Clear();
            TotalIncome = 0;
            ShowBills();
            ShowIncome();
            ShowAccounts();
        }

        private void CreateAccountRow(AccountModel model)
        {
            string combinedRowContent = string.Format("{0},{1},{2},", model.CompanyName, DollarFormat(model.AccountBalance), model.IsActive);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = model;
            listViewAccounts.Items.Add(item);
        }

        private void CreateBillRow(AccountModel model)
        {
            if (!model.IsActive)
            {
                return;
            }

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
            string amount = decimal.Round(budget.Amount, 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
            string combinedRowContent = string.Format("{0}, {1}", amount, budget.Date);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            listViewBudget.Items.Add(item);
        }

        private void CreateIncomeRow(PayDayModel model)
        {
            string combinedRowContent = string.Format("{0}, {1}", DollarFormat(model.Amount), model.Date);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = model;
            ListViewItem clonedItem = (ListViewItem)item.Clone();
            listViewIncome.Items.Add(item);
            listViewConfigIncome.Items.Add(clonedItem);
            TotalIncome += model.Amount;
        }

        private void GenerateBillsIfNewMonth()
        {
            Presenter.GenerateBillsIfNewMonth();
        }

        private AccountModel GetSelectedAccount(ListView view)
        {
            // guard clause - no selection
            ListView.SelectedListViewItemCollection selectedItems = view.SelectedItems;
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
            AccountModel selectedAccount = selectedLvi.Tag as AccountModel;
            if (selectedAccount == null)
            {
                return null;
            }

            return selectedAccount;
        }

        private PayDayModel GetSelectedIncome(ListView view)
        {
            // guard clause - no selection
            ListView.SelectedListViewItemCollection selectedItems = view.SelectedItems;
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

        private void ShowAccounts()
        {
            AccountModel[] models = Presenter.GetAccounts();
            models.OrderBy(a => a.CompanyName).ToList().ForEach(CreateAccountRow);
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

        private void ShowIncome()
        {
            PayDayModel[] models = Presenter.GetPayDaysInMonth(DisplayedDate);

            if (models.Length < 1)
            {
                PayDayModel payDayModel = new PayDayModel();
                payDayModel.Date = new DateTime(DisplayedDate.Year, DisplayedDate.Month, 1);
                payDayModel.RecordId = 0;
                payDayModel.Amount = 0;
                Presenter.AddPayDay(payDayModel);
                models = Presenter.GetPayDaysInMonth(DisplayedDate);
            }

            models.OrderBy(pdm => pdm.Date).Where(pdm => pdm.Date.Month == DisplayedDate.Month && pdm.Date.Year == DisplayedDate.Year).ToList().ForEach(CreateIncomeRow);
            labelTotalIncome.Text = decimal.Round(TotalIncome, 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
        }


        private void SortAccountsByAccountBalance()
        {
            listViewAccounts.Items.Clear();
            AccountModel[] models = Presenter.GetAccounts();
            models.OrderBy(a => a.AccountBalance).ToList().ForEach(CreateAccountRow);
        }

        private void SortAccountsByCompanyName()
        {
            listViewAccounts.Items.Clear();
            AccountModel[] models = Presenter.GetAccounts();
            models.OrderBy(a => a.CompanyName).ToList().ForEach(CreateAccountRow);
        }

        private void SortAccountsShowAllActiveAccountsOnTop()
        {
            listViewAccounts.Items.Clear();
            AccountModel[] models = Presenter.GetAccounts();
            models.OrderBy(a => !a.IsActive).ToList().ForEach(CreateAccountRow);
        }

        #endregion


    }
}
