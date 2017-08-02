using Domain;

namespace Presentation
{
    public class PayDaySaveFacade
    {

        #region Constructors

        public PayDaySaveFacade()
        {
        }

        #endregion

        #region Properties



        #endregion

        #region Public Methods

        public IPayDay Apply(PayDayModel model)
        {
            IPayDay payDay = new PayDay
            {
                Date = model.Date,
                Amount = model.Amount,
            };

            return payDay;
        }

        public IPayDay Apply(PayDayModel model, IPayDay payDay)
        {
            payDay.Date = model.Date;
            payDay.Amount = model.Amount;
            return payDay;
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
