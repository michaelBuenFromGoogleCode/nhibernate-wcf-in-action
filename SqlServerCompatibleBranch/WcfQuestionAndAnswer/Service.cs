using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;

using FluentNHibernate.LowercaseSystem;
using FluentNHibernate.Cfg.Db;
using NHibernate.Dialect;


using TheEntities.Mapper.Helpers;
using TheEntities;

using NHibernate.Linq;

namespace WcfQuestionAndAnswer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        ISessionFactory _sfx = null; 
        ISessionFactory SessionFactory
        {
            get
            {
                if (_sfx != null) return _sfx;

                _sfx = SessionFactoryBuilder.GetSessionFactory();

                return _sfx;

            }
        }


        public Service()
        {
            
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        
        public Question NewQuestion()
        {
            return new Question { TheQuestion = "What's the answer to life and everything?" };
        }

        
        public Question OpenQuestion(int questionId)
        {
            
            using (var s = SessionFactory.OpenSession() )
            {   
                /*var q = from x in s.Query<Question>()
                        where x.QuestionId == questionId
                        select x;
               
                return q.Single(); */

                return s.Get<Question>(questionId);
            }


        }

        
        public int SaveQuestion(Question q)
        {
            using (var s = SessionFactory.OpenSession())
            using (var tx = s.BeginTransaction())
            {                
                var qx = (Question)s.SaveOrUpdateCopy(q);
                tx.Commit();
                return qx.QuestionId;
            }
        }


    }


}
