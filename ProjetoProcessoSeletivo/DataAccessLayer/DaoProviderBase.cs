using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoProcessoSeletivo.DataAccessLayer
{
    public abstract class DaoProviderBase<T, V> : IDaoProvider<T, V>
                                            where T : new()
                                            where V : struct
    {
        protected readonly ISession CurrentNhibernateSession;

        protected DaoProviderBase()
        {
            CurrentNhibernateSession = ProjetoProcessoSeletivo.MvcApplication.NHibernateSessionFactory.GetCurrentSession();

        }
        public T Create<T>(T t)
        {
            using (ITransaction transaction = this.CurrentNhibernateSession.BeginTransaction())
            {
                this.CurrentNhibernateSession.Save(t);
                transaction.Commit();
            }
            return t;
        }

        public T    [] GetAll<T>()
        {
            var icriteria = this.CurrentNhibernateSession.CreateCriteria(typeof(T));
            return icriteria.List<T>().ToArray();
        }

        public T GetObjectById(V v)
        {
            return(T) this.CurrentNhibernateSession.Load(typeof(T), v);
        }

        public void Update(T t)
        {
            using (ITransaction transaction = this.CurrentNhibernateSession.BeginTransaction())
            {
                this.CurrentNhibernateSession.SaveOrUpdate(t);
                transaction.Commit();
            }
        }
    }
}