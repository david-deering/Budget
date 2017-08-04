using Domain;

namespace Presentation
{
    public class ConfirmDeletePresenter : AbstractPresenter
    {

        #region Constructors

        public ConfirmDeletePresenter()
        {
            AccountService = Factory.CreateAccountService();
            PayDayService = Factory.CreatePayDayService();
        }

        #endregion

        #region Properties

        private IAccountService AccountService { get; set; }
        private IPayDayService PayDayService { get; set; }


        #endregion

        #region Public Methods

        public void Delete(AccountModel model)
        {
            if (model != null)
            {
                AccountService.DeleteAccount(model.RecordId);
            }
        }

        public void Delete(PayDayModel model)
        {
            if (model != null)
            {
                PayDayService.DeletePayDay(model.RecordId);
            }
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
