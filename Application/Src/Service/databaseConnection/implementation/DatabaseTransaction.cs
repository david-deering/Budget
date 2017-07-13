using NHibernate;

namespace Service
{
    public class DatabaseTransaction : NullDatabaseTransaction
    {

        #region Constructors

        public DatabaseTransaction(ITransaction transaction)
        {
            _DatabaseTransaction = transaction;
        }

        #endregion

        #region Variables

        private readonly ITransaction _DatabaseTransaction;

        #endregion

        #region Overriden Methods

        public override void Commit()
        {
            _DatabaseTransaction.Commit();
        }

        public override void Dispose()
        {
            _DatabaseTransaction.Dispose();
        }

        public override void Rollback()
        {
            _DatabaseTransaction.Rollback();
        }

        #endregion

    }
}
