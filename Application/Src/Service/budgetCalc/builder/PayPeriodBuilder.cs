using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class PayPeriodBuilder : IPayPeriodBuilder
    {

        #region Constructors

        public PayPeriodBuilder(IPayDay payday, DateTime? nextPayDate)
        {
            Bills = new List<IBill>();
            Expenses = 0;
            NextPayDate = nextPayDate;
            PayDay = payday;
            Service = ServiceFactoryProxy.Singleton.ServiceFactory.CreateAccountService();
            StartDate = payday.Date;
            Surplus = payday.Amount;
        }

        #endregion

        #region Properties

        private List<IBill> Bills;

        public decimal Deficit { get; set; }
        private DateTime? NextPayDate { get; set; }
        public DateTime StartDate { get; set; }
        private IPayDay PayDay { get; set; }
        public decimal Surplus { get; set; }
        private IAccountService Service { get; set; }
        private decimal Expenses { get; set; }

        #endregion

        #region Public Methods


        public void Build()
        {
            GetBills();
            CalculateSurplus();
        }

        #endregion

        #region Helper Methods

        private void CalculateExpenses()
        {
            Bills.ForEach(AddExpense);
        }

        private void CalculateSurplus()
        {
            CalculateExpenses();

            if (Expenses > Surplus)
            {
                Deficit = Expenses - Surplus;
                Surplus = 0;
                return;
            }

            Surplus -= Expenses;
            Deficit = 0;
        }

        private void GetBills()
        {
            IAccount[] accounts = Service.GetAccounts();

            foreach (IAccount account in accounts)
            {
                IBill bill;

                if (NextPayDate == null)
                {
                    DateTime today = DateTime.Now;
                    DateTime endOfMonth = new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1);
                    bill = account.GetBills().FirstOrDefault(b => b.DateOwed >= PayDay.Date && b.DateOwed <= endOfMonth);

                }
                else
                {
                    bill = account.GetBills().FirstOrDefault(b => b.DateOwed >= PayDay.Date && b.DateOwed < NextPayDate);

                }

                //guard clause - null
                if (bill != null)
                {
                    Bills.Add(bill);
                }
            }

        }

        private void AddExpense(IBill bill)
        {
            Expenses += bill.MonthlyPayment;
        }

        #endregion

    }
}
