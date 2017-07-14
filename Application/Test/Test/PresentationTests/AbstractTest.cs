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
