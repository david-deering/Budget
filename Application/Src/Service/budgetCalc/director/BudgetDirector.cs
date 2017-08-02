using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class BudgetDirector
    {

        #region Constructors

        public BudgetDirector()
        {
            Service = ServiceFactoryProxy.Singleton.ServiceFactory.CreatePayDayService();
            PayDays = Service.GetPayDays().Where(pd => pd.Date.Month == DateTime.Now.Month).ToList();
            Result = new List<DateDecimal>();
            Builders = new List<IPayPeriodBuilder>();
        }

        #endregion

        #region Properties

        private List<IPayPeriodBuilder> Builders { get; set; }
        private List<IPayDay> PayDays { get; set; }
        private IPayDayService Service { get; set; }
        private List<DateDecimal> Result { get; set; }
        #endregion

        #region Public Methods

        public DateDecimal[] Construct()
        {
            PayDays = PayDays.OrderByDescending(pd => pd.Date).ToList();
            PayDays.ForEach(CreateBuilder);
            Builders.ForEach(b => b.Build());
            Balancer balancer = new Balancer(Builders.ToArray());
            balancer.BalanceBudget();
            Builders.ForEach(GetResult);
            Result = Result.GroupBy(dd => dd.Date).Select(dd => new DateDecimal(dd.Select(x => x.Date).First(), dd.Sum(y => y.Amount))).ToList();
            return Result.OrderBy(dd => dd.Date).ToArray();
        }

        #endregion

        #region Helper Methods

        private void CreateBuilder(IPayDay payDay)
        {
            if (PayDays[0].RecordId == payDay.RecordId)
            {
                Builders.Add(new PayPeriodBuilder(payDay, null));
                return;
            }

            int previousItem = PayDays.FindIndex(pd => pd.RecordId == payDay.RecordId) - 1;
            Builders.Add(new PayPeriodBuilder(payDay, PayDays[previousItem].Date));

        }

        private void GetResult(IPayPeriodBuilder builder)
        {
            DateTime date = builder.StartDate;
            decimal money;
            if (builder.Surplus > 0)
            {
                money = builder.Surplus;
            }
            else
            {
                money = -1 * builder.Deficit;
            }

            Result.Add(new DateDecimal(date, money));
        }

        #endregion

    }
}
