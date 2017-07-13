using Domain;
using System;

namespace Service
{
    public class ServiceEnvironment
    {

        public static ServiceEnvironment Singleton = new ServiceEnvironment();

        #region Constructors

        private ServiceEnvironment()
        {
            DatabaseConnectionFactoryRepository = new DatabaseConnectionFactoryRepository();
        }

        #endregion

        #region Properties

        private DatabaseConnectionFactoryRepository DatabaseConnectionFactoryRepository { get; set; }

        #endregion

        #region Public Methods

        public void Initialize()
        {
            try
            {
                DatabaseConnectionFactoryRepository.Initialize();
                ServiceFactoryProxy.Singleton.SetServiceFactory(new ServiceFactory(DatabaseConnectionFactoryRepository));
            }
            catch (ArgumentException ex)
            {
            }
        }

        #endregion

    }
}

