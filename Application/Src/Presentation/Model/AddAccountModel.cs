using System;

namespace Presentation
{
    public class AddAccountModel : AbstractModel
    {

        #region Constructors

        public AddAccountModel()
        {
            IsActive = true;
        }

        #endregion

        #region Properties

        public decimal AccountBalance { get; set; }
        public decimal AmountDue { get; set; }
        public decimal InterestRate { get; set; }
        public bool IsActive { get; set; }
        public string CompanyName { get; set; }

        public DateTime FirstDueDate { get; set; }


        #endregion

        #region Public Methods

        #endregion

        #region Helper Methods

        #endregion

    }
}
