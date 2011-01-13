using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Dialect;

using FluentNHibernate.LowercaseSystem;
using FluentNHibernate.Conventions.Helpers;

namespace TheEntities.Mapper.Helpers
{
    public static class SessionFactoryBuilder
    {
        static ISessionFactory _sf = null;
        public static ISessionFactory GetSessionFactory()
        {
            // Building SessionFactory is costly, should be done only once, making the backing variable static would prevent creating multiple factory

            if (_sf != null) return _sf;

            _sf = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard.ConnectionString("Server=localhost;Database=q_and_a;User ID=postgres;Password=opensesame"))
                .Mappings(m => m.FluentMappings.AddFromNamespaceOf<QuestionMap>().Conventions.ForLowercaseSystem("_id"))
                .BuildSessionFactory();

            return _sf;
        }

        public static string GetDatabaseSqlScript()
        {

                return
                    string.Join(";\n",

                        Fluently.Configure()
                            .Database(PostgreSQLConfiguration.Standard)
                            .Mappings(m => 
                                m.FluentMappings.AddFromNamespaceOf<QuestionMap>()
                                    // .Conventions.Add(LowercaseForeignKey.EndsWith("_ref"))
                                    .Conventions.ForLowercaseSystem("_id")
                                )
                            .BuildConfiguration()
                            .GenerateSchemaCreationScript(new PostgreSQLDialect())

                    );
           

        }
    }//SessionFactoryBuilder
    

}
