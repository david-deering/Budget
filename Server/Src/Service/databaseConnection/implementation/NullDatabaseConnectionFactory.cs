
namespace Service
{
    public class NullDatabaseConnectionFactory : IDatabaseConnectionFactory
    {

        #region Public Methods

        public virtual IDatabaseConnection FindOrCreateDatabaseConnection(string sessionId)
        {
            return new NullDatabaseConnection();
        }

        #endregion

    }
}
