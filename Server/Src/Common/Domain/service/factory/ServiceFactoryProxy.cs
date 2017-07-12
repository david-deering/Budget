namespace Domain
{
    public class ServiceFactoryProxy
    {

        public static ServiceFactoryProxy Singleton = new ServiceFactoryProxy();

        #region Constructors

        private ServiceFactoryProxy()
        {
            ServiceFactory = NullServiceFactory.Singleton;
        }

        #endregion

        #region Properties

        public IServiceFactory ServiceFactory { get; private set; }

        #endregion

        #region Public Methods

        public void SetServiceFactory(IServiceFactory serviceFactory)
        {
            ServiceFactory = serviceFactory;
        }

        #endregion

    }
}
