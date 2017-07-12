
namespace Service
{
    public class AbstractService
    {

        #region Constructors

        protected AbstractService(IDatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        #endregion

        #region Properties

        private IDatabaseConnection DatabaseConnection { get; set; }

        #endregion

        #region Shared Methods

        protected void Delete(object obj)
        {
            DatabaseConnection.Delete(obj);
        }

        protected T[] Get<T>()
        {
            return DatabaseConnection.Get<T>();
        }

        protected T Get<T>(int id)
        {
            return DatabaseConnection.Get<T>(id);
        }

        protected void Save(object o)
        {
            DatabaseConnection.Save(o);
        }

        protected void Update(object o)
        {
            DatabaseConnection.Update(o);
        }

        #endregion

    }
}
