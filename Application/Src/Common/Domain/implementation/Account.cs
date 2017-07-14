
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Domain
{
    public class Account : IAccount
    {

        #region Constructors

        public Account()
        {
            Bills = new Collection<IBill>();
        }

        #endregion

        #region Properties

        public virtual string CompanyName { get; set; }
        public virtual decimal AccountBalance { get; set; }
        public virtual decimal InterestRate { get; set; }
        public virtual int RecordId { get; set; }

        protected ICollection<IBill> Bills { get; set; }

        #endregion

        #region Public Methods

        public void GeneratePaymentSchedule(DateTime firstDueDate, decimal monthlyPayment)
        {
            ConfigureBills(firstDueDate, monthlyPayment);
        }

        public IBill[] GetBills()
        {
            return Bills.ToArray();
        }

        #endregion

        #region Helper Methods

        private void ConfigureBills(DateTime firstDueDate, decimal monthlyPayment)
        {
            Bills.Add(ConfigureBill(firstDueDate, monthlyPayment));

            DateTime date = GetNextMonthDueDate(firstDueDate);
            Bills.Add(ConfigureBill(date, monthlyPayment));

        }

        private Bill ConfigureBill(DateTime dueDate, decimal monthlyPayment)
        {
            Bill bill = new Bill();
            bill.DateOwed = dueDate;
            bill.MonthlyPayment = monthlyPayment;
            return bill;
        }

        private DateTime GetNextMonthDueDate(DateTime date)
        {
            DateTime newDate = date.AddMonths(1);
            return new DateTime(newDate.Year, newDate.Month, date.Day);
        }
        #endregion

    }
}
