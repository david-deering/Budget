using NHibernate;
using NHibernate.Linq;
using System;
using System.Data;
using System.Linq;

namespace Service
{
    public class DatabaseConnection : NullDatabaseConnection
    {

        #region Constructors

        public DatabaseConnection(ISession session)
        {
            Component = session;
        }

        #endregion

        #region Properties

        private ISession Component { get; set; }

        #endregion

        #region Overriden Methods

        public override void Delete(object obj)
        {
            Component.Delete(obj);
            TransactionalFlush();
        }

        public override T[] Get<T>()
        {
            return Component.Query<T>().ToArray();
        }

        public override T Get<T>(int id)
        {
            return Component.Get<T>(id);
        }

        public override void Save(object obj)
        {
            Component.Save(obj);
            TransactionalFlush();
        }

        public override void Update(object obj)
        {
            Component.Update(obj);
            TransactionalFlush();
        }

        #endregion

        #region Helper Methods

        private IDatabaseTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            IDatabaseTransaction transaction;
            try
            {
                transaction = new DatabaseTransaction(Component.BeginTransaction(isolationLevel));
                return transaction;
            }
            catch (Exception ex)
            {
                transaction = new NullDatabaseTransaction();

                return transaction;
            }
        }

        private void TransactionalFlush()
        {
            TransactionalFlush(IsolationLevel.ReadCommitted);
        }

        private void TransactionalFlush(IsolationLevel isolationLevel)
        {
            IDatabaseTransaction transaction = BeginTransaction(isolationLevel);
            try
            {
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw new ArgumentException("Exception_FailedToFlush");
            }
            finally
            {
                transaction.Dispose();
            }
        }

        #endregion

    }
}
