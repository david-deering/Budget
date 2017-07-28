using mainWindow;
using Presentation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class MainWindow : Form
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
            AccountWindow window = new AccountWindow();
            window.FormClosing += Action_FormClosing;
            window.Location = new Point(500, 500);
            window.Show();
        }

        private void buttonAddIncome_Click(object sender, EventArgs e)
        {
            AddIncomeWindow window = new AddIncomeWindow();
            window.FormClosing += Action_FormClosing;

            window.Location = new Point(500, 500);
            window.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountModel selectedAccount = GetSelectedAccount();
            Presenter.DeleteAccount(selectedAccount);
            lvMain.Items.Clear();
            ShowBills();

        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            AccountModel selectedAccount = GetSelectedAccount();

            AccountWindow window = new AccountWindow(selectedAccount);
            window.FormClosing += Action_FormClosing;

            window.Location = new Point(500, 500);
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

            EditBillWindow editBillWindow = new EditBillWindow(item.Tag as BillModel);
            editBillWindow.FormClosing += Action_FormClosing;

            editBillWindow.Location = new Point(500, 500);
            editBillWindow.Show();
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

        private ColumnHeader CreateHeader(string text, int pixelWidth)
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = text;
            header.Width = pixelWidth;
            return header;
        }

        private void CreateIncomeRow(PayDayModel model)
        {
            string combinedRowContent = string.Format("{0}, {1}", model.Amount, model.Date);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = model;
            listViewIncome.Items.Add(item);
            TotalIncome += model.Amount;
        }

        private ColumnHeader[] CreateHeaders()
        {
            string[] headerValues = Presenter.GetHeaderValues();
            List<ColumnHeader> headers = headerValues.Select(columnHeader => CreateHeader(columnHeader, 175)).ToList();
            return headers.ToArray();
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

            billModel.ParentId = model.RecordId;
            string combinedRowContent = string.Format("{0},{1},{2},{3},{4}, {5}", model.CompanyName, decimal.Round(model.AccountBalance, 2, MidpointRounding.AwayFromZero), decimal.Round(billModel.MonthlyPayment, 2, MidpointRounding.AwayFromZero), billModel.DateOwed.ToShortDateString(), paidStatus, billModel.ConfirmationNumber);
            string[] splitRowContent = combinedRowContent.Split(',');
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = billModel;
            lvMain.Items.Add(item);
        }

        private void ShowBills()
        {
            AccountModel[] accountModels = Presenter.GetAccounts();
            accountModels.ToList().ForEach(CreateBillRow);
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
