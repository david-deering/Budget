
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

        public virtual IBillService CreateBillService(string databaseId, string sessionid)
        {
            return NullBillService.Singleton;
        }

        #endregion

    }
}
