namespace Service
{
    public class NullDatabaseConnection : IDatabaseConnection
    {

        #region Public Methods

        public virtual void Delete(object obj)
        {
            // do nothing
        }

        public virtual T[] Get<T>()
        {
            return new T[0];
        }

        public virtual T Get<T>(int id)
        {
            return default(T);
        }

        public virtual void Save(object obj)
        {
            // do nothing
        }

        public virtual void Update(object obj)
        {
            // do nothing
        }

        #endregion

    }
}
