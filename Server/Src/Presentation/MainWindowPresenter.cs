using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentation
{
    public class MainWindowPresenter : AbstractPresenter
    {

        #region Constructors

        public MainWindowPresenter()
        {
            BillService = Factory.CreateBillService(string.Empty, string.Empty);
        }

        #endregion

        #region Properties

        private IBillService BillService { get; set; }

        #endregion

        #region Private Members

        private const string Header1 = "Company Name";
        private const string Header2 = "Monthly Payment";
        private const string Header3 = "Date Due";
        private const string Header4 = "Full Amount";

        #endregion

        #region Public Methods

        public void MakeDatabaseEntries()
        {
            IBill bill = new Bill();
            bill.DateOwed = new DateTime(2017, 05, 23);
            bill.MonthlyPayment = 5.67m;
            bill.Name = "Haribo";
            bill.TotalOwed = 10.00m;

            BillService.AddBill(bill);
        }

        public string[] GetHeaderValues()
        {
            List<string> values = new List<string>();
            values.Add(Header1);
            values.Add(Header2);
            values.Add(Header3);
            values.Add(Header4);
            return values.ToArray();
        }

        public ListViewItem[] CreateRows()
        {
            IBill[] bills = BillService.GetBills();

            // guard clause - empty
            if (bills.Length == 0)
            {
                return new ListViewItem[0];
            }

            return bills.Select(CreateRow).ToArray();
        }
        #endregion


        #region Helper Methods

        private ListViewItem CreateRow(IBill bill)
        {
            BillModel model = new BillModel();
            model.CopyFrom(bill);

            string combinedRowContent = string.Format("{0},{1},{2},{3}", model.Name, decimal.Round(model.MonthlyPayment, 2, MidpointRounding.AwayFromZero), model.DateOwed.ToShortDateString(), decimal.Round(model.TotalOwed, 2, MidpointRounding.AwayFromZero));
            string[] splitRowContent = combinedRowContent.Split(new char[] { ',' });
            ListViewItem item = new ListViewItem(splitRowContent);
            item.Tag = model;
            return item;
        }
        #endregion

    }
}
