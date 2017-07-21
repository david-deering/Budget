using Domain;
using System;

namespace Test.PresentationTests
{
    public abstract class AbstractTest
    {

        #region Constructors

        public AbstractTest()
        {
        }

        #endregion

        #region Constants

        public const decimal AccountBalance = 100.99m;
        public const string CompanyName = "Test";
        public const decimal AmountDue = 2m;
        public const decimal InterestRate = 2m;
        public const int RecordIdIs0 = 0;


        #endregion

        #region Properties



        #endregion

        #region Public Methods

        public IBill CreateBill()
        {
            IBill bill = new Bill();
            bill.DateOwed = new DateTime(2017, 05, 23);
            bill.MonthlyPayment = 5.67m;
            return bill;
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
