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

        public void AddPayDay(PayDayModel model)
        {
            IPayDay payDay = Apply(model);
            Service.AddPayDay(payDay);
        }
        public PayDayModel GetPayDay(PayDayModel model)
        {
            IPayDay payDay = Service.GetPayDay(model.RecordId);
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

        private IPayDay Apply(PayDayModel model)
        {
            PayDaySaveFacade facade = new PayDaySaveFacade();
            return facade.Apply(model);
        }

        private PayDayModel CreateModel(IPayDay payday)
        {
            PayDayModel model = new PayDayModel();
            model.CopyFrom(payday);
            return model;
        }

        #endregion
    }
}
