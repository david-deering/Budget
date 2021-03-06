﻿using Domain;
using System;

namespace Presentation
{
    public class PayDayModel : AbstractModel
    {

        #region Constructors

        public PayDayModel()
        {
        }

        #endregion

        #region Properties

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public int RecordId { get; set; }

        #endregion

        #region Public Methods


        public void CopyFrom(IPayDay payDay)
        {
            Date = payDay.Date;
            Amount = payDay.Amount;
            RecordId = payDay.RecordId;
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
