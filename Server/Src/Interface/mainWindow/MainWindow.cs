using mainWindow;
using Presentation;
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
            AddRows();
        }

        #endregion

        #region Properties

        private ColumnHeader[] Headers { get; set; }
        private MainWindowPresenter Presenter { get; set; }

        #endregion

        #region Helper Methods

        private void SetHeaders()
        {
            Headers = CreateHeaders();
            lvMain.Columns.AddRange(Headers);
        }

        private void AddRows()
        {
            Presenter.CreateRows().ToList().ForEach(AddRow);
        }

        private void AddRow(ListViewItem item)
        {
            lvMain.Items.Add(item);
        }

        #endregion

        #region Event Handlers

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvMain.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            EditBillWindow editBillWindow = new EditBillWindow(item.Tag as BillModel);
            editBillWindow.FormClosing += EditBill_FormClosing;

            editBillWindow.Location = new Point(500, 500);
            editBillWindow.Show();
        }

        private void EditBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            lvMain.Items.Clear();
            AddRows();
        }
        #endregion


        #region Helper Methods

        private ColumnHeader[] CreateHeaders()
        {
            string[] headerValues = Presenter.GetHeaderValues();
            List<ColumnHeader> headers = headerValues.Select(columnHeader => CreateHeader(columnHeader, 200)).ToList();
            return headers.ToArray();
        }

        private ColumnHeader CreateHeader(string text, int pixelWidth)
        {
            ColumnHeader header = new ColumnHeader();
            header.Text = text;
            header.Width = pixelWidth;
            return header;
        }

        #endregion

    }
}
