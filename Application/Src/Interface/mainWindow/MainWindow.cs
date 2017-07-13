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
            //TODO: Remove when able to make real entries
            //Presenter.MakeDatabaseEntries();

            SetHeaders();
            CreateRows();
        }

        #endregion

        #region Properties

        private ColumnHeader[] Headers { get; set; }
        private MainWindowPresenter Presenter { get; set; }

        #endregion

        #region Event Handlers

        private void EditBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            lvMain.Items.Clear();
            CreateRows();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvMain.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            EditBillWindow editBillWindow = new EditBillWindow(item.Tag as BillModel);
            editBillWindow.FormClosing += EditBill_FormClosing;

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
            List<ColumnHeader> headers = headerValues.Select(columnHeader => CreateHeader(columnHeader, 200)).ToList();
            return headers.ToArray();
        }

        private void CreateRow(BillModel model)
        {
            string combinedRowContent = string.Format("{0},{1},{2},{3}", model.Name, decimal.Round(model.MonthlyPayment, 2, MidpointRounding.AwayFromZero), model.DateOwed.ToShortDateString(), decimal.Round(model.TotalOwed, 2, MidpointRounding.AwayFromZero));
            string[] splitRowContent = combinedRowContent.Split(new char[] { ',' });
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = model;
            lvMain.Items.Add(item);
        }

        private void CreateRows()
        {
            BillModel[] models = Presenter.GetBills();
            List<BillModel> modelList = models.ToList();

            modelList.ForEach(CreateRow);
        }

        private void SetHeaders()
        {
            Headers = CreateHeaders();
            lvMain.Columns.AddRange(Headers);
        }

        #endregion

    }
}
