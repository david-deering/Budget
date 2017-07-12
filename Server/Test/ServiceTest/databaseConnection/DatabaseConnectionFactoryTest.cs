using NUnit.Framework;
using Service;

namespace Dmi.ServiceTest
{
    [TestFixture]
    public class DatabaseConnectionFactoryTest
    {

        private IDatabaseConnectionFactory databaseConnectionFactory;

        #region SetUp

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {

        }

        #endregion

        # region Blue Sky Tests

        [Test]
        public void TestBlueSky_FindOrCreateDatabaseConnection()
        {
            // set up
            DatabaseConnectionFactoryRepository databaseConnectionFactoryRepository = new DatabaseConnectionFactoryRepository();
            databaseConnectionFactoryRepository.Initialize();
            databaseConnectionFactory = databaseConnectionFactoryRepository.FindOrCreateDatabaseConnectionFactory(string.Empty);

            // exercise
            try
            {
                IDatabaseConnection databaseConnection = databaseConnectionFactory.FindOrCreateDatabaseConnection(string.Empty);
                Assert.AreEqual(typeof(DatabaseConnection), databaseConnection.GetType());
            }
            catch
            {
                Assert.Fail();
            }
        }

        # endregion

        # region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_FindOrCreateDatabaseConnectionNotInitialized()
        {
            // set up
            DatabaseConnectionFactoryRepository databaseConnectionFactoryRepository = new DatabaseConnectionFactoryRepository();
            databaseConnectionFactory = databaseConnectionFactoryRepository.FindOrCreateDatabaseConnectionFactory(string.Empty);
            IDatabaseConnection databaseConnection = null;

            // exercise
            try
            {
                databaseConnection = databaseConnectionFactory.FindOrCreateDatabaseConnection(string.Empty);
                Assert.Fail();
            }
            catch
            {
                Assert.AreEqual(typeof(NullDatabaseConnection), databaseConnection.GetType());
            }
        }

        # endregion

        #region Tear Down

        [TearDown]
        public void TearDown()
        {
        }

        #endregion

    }
}
