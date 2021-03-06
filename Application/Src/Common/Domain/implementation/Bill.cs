﻿using System;

namespace Domain
{
    public class Bill : IBill
    {

        #region Constructors

        public Bill()
        {
        }

        #endregion

        #region Properties

        public virtual string ConfirmationNumber { get; set; }
        public virtual DateTime DateOwed { get; set; }
        public virtual decimal MonthlyPayment { get; set; }
        public virtual bool Paid { get; set; }
        public virtual int RecordId { get; set; }

        #endregion

    }
}
