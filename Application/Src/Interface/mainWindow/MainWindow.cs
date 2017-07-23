using mainWindow;
using Presentation;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            labelMonth.Text = string.Format("{0:MMMM}, {1:yyyy}", DisplayedDate, DisplayedDate);
            //Presenter.MakeDatabaseEntries();
            //SetHeaders();
            CreateRows();
        }

        #endregion

        #region Properties

        private ColumnHeader[] Headers { get; set; }
        private MainWindowPresenter Presenter { get; set; }
        private DateTime DisplayedDate { get; set; }

        #endregion

        private string paid = "paid";
        private string notPaid = "not paid";

        #region Event Handlers

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AccountWindow window = new AccountWindow();
            window.FormClosing += Action_FormClosing;
            window.Location = new Point(500, 500);
            window.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountModel selectedAccount = GetSelectedAccount();
            Presenter.DeleteAccount(selectedAccount);
            lvMain.Items.Clear();
            CreateRows();

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
            labelMonth.Text = string.Format("{0:MMMM}, {1:yyyy}", DisplayedDate, DisplayedDate); ;
            lvMain.Items.Clear();
            CreateRows();
        }

        private void buttonPrevMonth_Click(object sender, EventArgs e)
        {
            DisplayedDate = DisplayedDate.AddMonths(-1);
            labelMonth.Text = string.Format("{0:MMMM}, {1:yyyy}", DisplayedDate, DisplayedDate); ;
            lvMain.Items.Clear();
            CreateRows();
        }



        private void Action_FormClosing(object sender, FormClosingEventArgs e)
        {
            lvMain.Items.Clear();
            CreateRows();
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

        private ColumnHeader CreateHeader(string text, int pixelWidth)
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = text;
            header.Width = pixelWidth;
            return header;
        }

        private ColumnHeader[] CreateHeaders()
        {
            string[] headerValues = Presenter.GetHeaderValues();
            List<ColumnHeader> headers = headerValues.Select(columnHeader => CreateHeader(columnHeader, 175)).ToList();
            return headers.ToArray();
        }

        private void CreateRow(AccountModel model)
        {
            BillModel billModel = model.Bills.FirstOrDefault(bm => (bm.DateOwed.Month == DisplayedDate.Month) && (bm.DateOwed.Year == DisplayedDate.Year));

            //guard clause - no item
            if (billModel == null)
            {
                return;
            }

            string paidStatus;
            if (billModel.Paid)
            {
                paidStatus = paid;
            }
            else
            {
                paidStatus = notPaid;
            }

            billModel.ParentId = model.RecordId;
            string combinedRowContent = string.Format("{0},{1},{2},{3},{4}", model.CompanyName, decimal.Round(billModel.MonthlyPayment, 2, MidpointRounding.AwayFromZero), billModel.DateOwed.ToShortDateString(), decimal.Round(model.AccountBalance, 2, MidpointRounding.AwayFromZero), paidStatus);
            string[] splitRowContent = combinedRowContent.Split(new char[] { ',' });
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = billModel;
            lvMain.Items.Add(item);
        }

        private void CreateRows()
        {
            AccountModel[] accountModels = Presenter.GetAccounts();
            accountModels.ToList().ForEach(CreateRow);
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

        private void SetHeaders()
        {
            Headers = CreateHeaders();
            lvMain.Columns.AddRange(Headers);
        }

        #endregion

    }
}
