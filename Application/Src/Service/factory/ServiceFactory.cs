using Domain;

namespace Service
{
    public class ServiceFactory : NullServiceFactory
    {

        #region Constructors

        public ServiceFactory(DatabaseConnectionFactoryRepository databaseConnectionFactoryRepository)
        {
            DatabaseConnectionFactoryRepository = databaseConnectionFactoryRepository;
        }

        #endregion

        #region Properties

        private DatabaseConnectionFactoryRepository DatabaseConnectionFactoryRepository { get; set; }

        #endregion

        #region Overriden Methods

        public override IAccountService CreateAccountService()
        {
            IDatabaseConnectionFactory databaseConnectionFactory = DatabaseConnectionFactoryRepository.FindOrCreateDatabaseConnectionFactory(string.Empty);
            IDatabaseConnection databaseConnection = databaseConnectionFactory.FindOrCreateDatabaseConnection(string.Empty);

            return new AccountService(databaseConnection);

        }

        #endregion

    }
}
