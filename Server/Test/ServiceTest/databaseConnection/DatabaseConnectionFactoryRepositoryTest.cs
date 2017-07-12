using NUnit.Framework;
using Service;

namespace Dmi.ServiceTest
{
    [TestFixture]
    public class DatabaseConnectionFactoryRepositoryTest
    {

        #region SetUp

        [SetUp]
        public void SetUp()
        {
        }

        #endregion

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_Initialize()
        {
            DatabaseConnectionFactoryRepository databaseConnectionFactoryRepository = new DatabaseConnectionFactoryRepository();
            databaseConnectionFactoryRepository.Initialize();
        }

        [Test]
        public void TestBlueSky_FindOrCreateDatabaseConnectionFactory()
        {
            DatabaseConnectionFactoryRepository databaseConnectionFactoryRepository = new DatabaseConnectionFactoryRepository();
            databaseConnectionFactoryRepository.Initialize();

            IDatabaseConnectionFactory databaseConnectionFactory = databaseConnectionFactoryRepository.FindOrCreateDatabaseConnectionFactory(string.Empty);
            Assert.AreEqual(typeof(DatabaseConnectionFactory), databaseConnectionFactory.GetType());
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_FindOrCreateDatabaseConnectionFactoryNotInitialized()
        {
            DatabaseConnectionFactoryRepository databaseConnectionFactoryRepository = new DatabaseConnectionFactoryRepository();
            IDatabaseConnectionFactory databaseConnectionFactory = null;

            try
            {
                databaseConnectionFactory = databaseConnectionFactoryRepository.FindOrCreateDatabaseConnectionFactory(string.Empty);
                Assert.Fail();
            }
            catch
            {
                Assert.AreEqual(typeof(NullDatabaseConnectionFactory), databaseConnectionFactory.GetType());
            }
        }

        #endregion

        #region Tear Down

        [TearDown]
        public void TearDown()
        {
        }

        #endregion

    }
}