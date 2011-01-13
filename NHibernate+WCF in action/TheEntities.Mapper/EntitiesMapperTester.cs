using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using FluentNHibernate.LowercaseSystem;
using NHibernate.Dialect;

using TheEntities.Mapper;

using TheEntities.Mapper.Helpers;

namespace TheEntities.Mapper
{
    class EntitiesMapperTester
    {
        static void Main(string[] args)
        {

            // Building SessionFactory is costly, should be done only once, making the backing variable static would prevent creating multiple factory

            try
            {

                // Helpers.SessionFactoryBuilder.GetSessionFactory();
                Console.WriteLine("Copy this script:\n\n{0}", Helpers.SessionFactoryBuilder.GetDatabaseSqlScript());
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine("EXCEPTION\n{0}", ex.InnerException.Message + "\n\n" + ex.InnerException.StackTrace);                    
                }
            }


            Console.ReadLine();
            

            
        }
    }
}



