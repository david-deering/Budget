
using Domain;
using NUnit.Framework;
using Service;

namespace Dmi.ServiceTest
{
    public class AbstractServiceTest
    {

        #region Constructors

        protected AbstractServiceTest()
        {
            ServiceFactory = NullServiceFactory.Singleton;
        }

        #endregion

        #region Properties

        protected static IServiceFactory ServiceFactory { get; private set; }

        #endregion

        [TestFixtureSetUp]
        public void SetUpTestFixture()
        {
            ServiceEnvironment.Singleton.Initialize();
            ServiceFactory = ServiceFactoryProxy.Singleton.ServiceFactory;
        }

        [TestFixtureTearDown]
        public void TearDownTestFixture()
        {
        }

    }
}
