using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using ProjetoProcessoSeletivo.NhibernateMappingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProcessoSeletivo.NhibernateHelpers
{
    public static class NhibernateSessionHelper
    {
        public static ISessionFactory GetNhibernateSessionFactory()
        {
            var configuration = new Configuration();
            configuration.DataBaseIntegration(config =>
            {
                config.Dialect<NHibernate.Dialect.MsSql2008Dialect>();
                config.Driver<NHibernate.Driver.Sql2008ClientDriver>();
                config.ConnectionStringName = "projetoSeletivoConnectionString";
                config.ConnectionProvider<NHibernate.Connection.DriverConnectionProvider>();
            });
            configuration.CurrentSessionContext<WebSessionContext>();
            configuration.AddAssembly(typeof(Categoria).Assembly);
            return configuration.BuildSessionFactory();
        }
    }
}