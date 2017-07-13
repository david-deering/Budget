
namespace Service
{
    public class NullDatabaseTransaction : IDatabaseTransaction
    {

        #region Public Methods

        public virtual void Commit()
        {
            // do nothing
        }

        public virtual void Dispose()
        {
            // do nothing
        }

        public virtual void Rollback()
        {
            // do nothing
        }

        #endregion

    }
}
