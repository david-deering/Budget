
namespace Domain
{
    public class NullServiceFactory : IServiceFactory
    {

        public static IServiceFactory Singleton = new NullServiceFactory();

        #region Constructors

        protected NullServiceFactory()
        {
        }

        #endregion

        #region Public Methods

        public virtual IAccountService CreateAccountService()
        {
            return NullAccountService.Singleton;
        }

        public virtual IPayDayService CreatePayDayService()
        {
            return NullPayDayService.Singleton;
        }
        #endregion

    }
}
