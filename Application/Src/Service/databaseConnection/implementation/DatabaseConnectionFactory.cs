using Domain;
using NHibernate;
using System;

namespace Service
{
    public class DatabaseConnectionFactory : NullDatabaseConnectionFactory
    {

        #region Constructors

        public DatabaseConnectionFactory(ISessionFactory sessionFactory)
        {
            SessionFactory = sessionFactory;
            DatabaseConnectionMap = new ThreadSafeMap<string, IDatabaseConnection>();
        }

        #endregion

        #region Properties

        private ThreadSafeMap<string, IDatabaseConnection> DatabaseConnectionMap { get; set; }
        private ISessionFactory SessionFactory { get; set; }

        #endregion

        #region Overriden Methods

        public override IDatabaseConnection FindOrCreateDatabaseConnection(string sessionId)
        {

            IDatabaseConnection foundDatabaseConnection;

            // guard clause - already mapped
            if (DatabaseConnectionMap.TryGetValue(sessionId, out foundDatabaseConnection))
            {
                return foundDatabaseConnection;
            }

            IDatabaseConnection databaseConnection;
            try
            {
                ISession openSession = OpenSession();
                databaseConnection = new DatabaseConnection(openSession);
                DatabaseConnectionMap[sessionId] = databaseConnection;
                return databaseConnection;
            }
            catch (Exception ex)
            {
                databaseConnection = new NullDatabaseConnection();
                return databaseConnection;
            }
        }

        #endregion

        #region Helper Methods

        private ISession OpenSession()
        {
            ISession openSession = SessionFactory.OpenSession();
            openSession.FlushMode = FlushMode.Commit;

            return openSession;
        }

        #endregion

    }
}
