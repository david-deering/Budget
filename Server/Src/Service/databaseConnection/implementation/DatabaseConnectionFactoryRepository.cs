using Domain;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.IO;

namespace Service
{
    public class DatabaseConnectionFactoryRepository
    {

        #region Constructors

        public DatabaseConnectionFactoryRepository()
        {
            BaseConfiguration = null;
            DatabaseConnectionFactoryMap = new ThreadSafeMap<string, IDatabaseConnectionFactory>();
        }

        #endregion

        #region Properties

        private Configuration BaseConfiguration { get; set; }
        private ThreadSafeMap<string, IDatabaseConnectionFactory> DatabaseConnectionFactoryMap { get; set; }

        #endregion

        #region Public Methods

        public IDatabaseConnectionFactory FindOrCreateDatabaseConnectionFactory(string databaseId)
        {
            IDatabaseConnectionFactory foundDatabaseConnectionFactory;

            // guard clause - already mapped
            if (DatabaseConnectionFactoryMap.TryGetValue(databaseId, out foundDatabaseConnectionFactory))
            {
                return foundDatabaseConnectionFactory;
            }

            IDatabaseConnectionFactory databaseConnectionFactory;
            try
            {
                ISessionFactory sessionFactory = BaseConfiguration.BuildSessionFactory();
                databaseConnectionFactory = new DatabaseConnectionFactory(sessionFactory);
                DatabaseConnectionFactoryMap[databaseId] = databaseConnectionFactory;

                return databaseConnectionFactory;
            }

            catch (Exception ex)
            {
                databaseConnectionFactory = new NullDatabaseConnectionFactory();

                return databaseConnectionFactory;
            }
        }

        public void Initialize()
        {
            try
            {
                BaseConfiguration = CreateBaseConfiguration();
                BaseConfiguration.AddAssembly(GetType().Assembly);
                new SchemaUpdate(BaseConfiguration).Execute(false, true);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Exception_FailedToConfigureNHibernate");
            }
        }

        #endregion

        #region Helper Methods

        private Configuration CreateBaseConfiguration()
        {
            // guard clause - already initialized
            if (BaseConfiguration != null)
            {
                return BaseConfiguration;
            }

            BaseConfiguration = new Configuration();
            string nHibernateConfigFilePath = GetRootedPath(ServiceConstants.NHIBERNATE_CONFIGURATION_FILENAME);

            if (File.Exists(nHibernateConfigFilePath))
            {
                BaseConfiguration.Configure(nHibernateConfigFilePath);
            }
            else
            {
                string message = string.Format("ServiceResource.Exception_NhibernateConfigurationFileNotFound, nHibernateConfigFilePath");
                throw new ArgumentException("Common.Exception_NhibernateFileNotFound");
            }

            return BaseConfiguration;
        }

        private string GetRootedPath(string filePath)
        {
            // guard clause - rooted path
            if (Path.IsPathRooted(filePath))
            {
                return filePath;
            }

            string currentDirectory = System.Environment.CurrentDirectory;
            return Path.Combine(currentDirectory, "../../cfg", filePath);
        }

        #endregion

    }
}
