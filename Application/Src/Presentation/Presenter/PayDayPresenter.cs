using Domain;
using System;
using System.Linq;

namespace Presentation.Presenter
{
    public class PayDayPresenter : AbstractPresenter
    {
        public PayDayPresenter()
        {
            Service = Factory.CreatePayDayService();
        }

        #region Properties

        private IPayDayService Service { get; }

        #endregion

        #region Public Methods
        public void DeletePayDay(int recordId)
        {
            Service.DeletePayDay(recordId);
        }

        public void SavePayDay(PayDayModel model)
        {
            IPayDay payDayExists = Service.GetPayDay(model.RecordId);
            PayDaySaveFacade facade = new PayDaySaveFacade();

            if (payDayExists == null)
            {
                IPayDay payDay = facade.Apply(model);
                Service.AddPayDay(payDay);
                return;
            }

            payDayExists = facade.Apply(model, payDayExists);
            Service.UpdatePayDay(payDayExists);
        }
        public PayDayModel GetPayDay(int recordId)
        {
            PayDayModel model = new PayDayModel();
            IPayDay payDay = Service.GetPayDay(recordId);
            model.CopyFrom(payDay);
            return model;
        }

        public PayDayModel[] GetPayDaysInMonth(DateTime date)
        {
            return Service.GetPayDays().Where(pd => pd.Date.Month == date.Month && pd.Date.Year == date.Year).Select(CreateModel).ToArray();
        }

        public void UpdatePayDay(PayDayModel model)
        {
            IPayDay payDay = Service.GetPayDay(model.RecordId);
            payDay.Date = model.Date;
            payDay.Amount = model.Amount;
            Service.UpdatePayDay(payDay);
        }

        #endregion

        #region Private Method

        private PayDayModel CreateModel(IPayDay payday)
        {
            PayDayModel model = new PayDayModel();
            model.CopyFrom(payday);
            return model;
        }

        #endregion
    }
}
