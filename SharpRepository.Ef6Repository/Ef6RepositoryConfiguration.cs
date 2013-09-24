using System;
using SharpRepository.Repository.Configuration;

namespace SharpRepository.Ef6Repository
{
    public class Ef6RepositoryConfiguration : RepositoryConfiguration
    {
        public Ef6RepositoryConfiguration(string name) : this(name, null, null)
        {
        }

        public Ef6RepositoryConfiguration(string name, string connectionStringOrName)
            : this(name, connectionStringOrName, null)
        {
        }

        public Ef6RepositoryConfiguration(string name, string connectionStringOrName, Type dbContextType, string cachingStrategy=null, string cachingProvider=null)
            : base(name)
        {
            ConnectionStringOrName = connectionStringOrName;
            DbContextType = dbContextType;
            CachingStrategy = cachingStrategy;
            CachingProvider = cachingProvider;
            Factory = typeof(Ef6ConfigRepositoryFactory);
        }

        public string ConnectionStringOrName
        {
            set { Attributes["connectionString"] = value; }
        }

        public Type DbContextType
        {
            set
            {
                if (value == null)
                    return;

                Attributes["dbContextType"] = value.AssemblyQualifiedName;
            }
        }
    }
}
