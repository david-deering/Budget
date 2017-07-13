namespace Service
{
    public interface IDatabaseConnectionFactory
    {

        IDatabaseConnection FindOrCreateDatabaseConnection(string sessionId);

    }
}