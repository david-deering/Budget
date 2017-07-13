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


        public override IBillService CreateBillService(string databaseId, string sessionId)
        {
            IDatabaseConnectionFactory databaseConnectionFactory = DatabaseConnectionFactoryRepository.FindOrCreateDatabaseConnectionFactory(databaseId);
            IDatabaseConnection databaseConnection = databaseConnectionFactory.FindOrCreateDatabaseConnection(sessionId);

            return new BillService(databaseConnection);
        }
        #endregion

    }
}
