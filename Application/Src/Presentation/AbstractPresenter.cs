using Domain;

namespace Presentation
{
    public abstract class AbstractPresenter
    {

        #region Constructors

        protected AbstractPresenter()
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
