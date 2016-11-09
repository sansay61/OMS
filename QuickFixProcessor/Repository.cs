using NHibernate;
using System;
using System.Collections.Generic;using QuickFixProcessor.Interfaces;
using System.Linq;
using System.Web;

using NHibernate.Linq;


namespace QuickFixProcessor
{
    public class Repository<T> : IRepository<T>
    {
        public IEnumerable<T> GetAll()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Query<T>().ToList();
            }
            
        }

        public T GetById(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.Get<T>(id);
            }
           
        }

        public void Create(T entity)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entity);
                        tx.Commit();

                    }
                    catch (Exception e)
                    {
                        tx.Rollback();
                    }
                }
            }
        }

        public void Update(T entity)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entity);
                        tx.Commit();
                    }
                    catch (Exception e)
                    {
                        tx.Rollback();
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(session.Load<T>(id));
                        tx.Commit();

                    }
                    catch (Exception e)
                    {
                        tx.Rollback();
                    }
                }
            }
        }
    }
}