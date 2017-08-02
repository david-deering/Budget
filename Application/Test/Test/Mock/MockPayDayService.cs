using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Test.Mock
{
    public class MockPayDayService : IPayDayService
    {
        public static MockPayDayService Singleton = new MockPayDayService();
        #region Constructors

        public MockPayDayService()
        {
            RecordIdGenerator = 1;
            PayDays = new List<IPayDay>();
        }

        #endregion

        #region Properties

        private int RecordIdGenerator { get; set; }
        private List<IPayDay> PayDays { get; set; }

        #endregion

        #region Public Methods
        public void AddPayDay(IPayDay payDay)
        {
            // guard clause - invalid input
            if (payDay == null)
            {
                return;
            }

            payDay.RecordId = RecordIdGenerator;
            PayDays.Add(payDay);
            RecordIdGenerator++;
        }

        public void DeletePayDay(int recordId)
        {
            // guard clause - not found
            IPayDay foundPayDay = PayDays.FirstOrDefault(pd => pd.RecordId == recordId);
            if (foundPayDay == null)
            {
                return;
            }

            PayDays.Remove(foundPayDay);
        }

        public IPayDay GetPayDay(int recordId)
        {
            // guard clause - not found
            IPayDay payDay = PayDays.FirstOrDefault(pd => pd.RecordId == recordId);
            return payDay;
        }

        public IPayDay[] GetPayDays()
        {
            return PayDays.ToArray();
        }


        public void UpdatePayDay(IPayDay payDay)
        {
            // guard clause - invalid input
            if (payDay == null)
            {
                return;
            }

            IPayDay foundPayDay = PayDays.FirstOrDefault(pd => pd.RecordId == payDay.RecordId);

            if (foundPayDay == null)
            {
                return;
            }

            foundPayDay.Date = payDay.Date;
            foundPayDay.Amount = payDay.Amount;
        }


        #endregion

        #region Helper Methods



        #endregion

    }
}
