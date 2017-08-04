using Domain;

namespace Presentation
{
    public abstract class AbstractPresenter
    {

        #region Constructors

        protected AbstractPresenter()
        {
            Factory = ServiceFactoryProxy.Singleton.ServiceFactory;
        }

        #endregion

        #region Properties


        protected IServiceFactory Factory { get; private set; }

        #endregion

        #region Public Methods

        #endregion

        #region Helper Methods



        #endregion

    }
}
