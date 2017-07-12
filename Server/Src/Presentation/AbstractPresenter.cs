using Domain;

namespace Presentation
{
    public abstract class AbstractPresenter
    {

        #region Constructors

        public AbstractPresenter()
        {
        }

        #endregion

        #region Properties


        protected IServiceFactory Factory = ServiceFactoryProxy.Singleton.ServiceFactory;

        #endregion

        #region Public Methods



        #endregion

        #region Helper Methods



        #endregion

    }
}
