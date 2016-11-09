using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderManagementSystem.Models;
using Microsoft.AspNet.Identity;


namespace OrderManagementSystem.UoF
{
    public class UnitOfWork : IUnitOfWork
    {
        private static readonly ISessionFactory _sessionFactory;
        private ITransaction _transaction;

        public ISession Session { get; private set; }

        static UnitOfWork()
        {
            if (_sessionFactory == null)
            {
               
                var dbConfig = OracleDataClientConfiguration.Oracle10
                  .ConnectionString(c => c.FromConnectionStringWithKey("Oracle"))
                  .Driver<OracleDataClientDriver>()
                  .ShowSql();

                _sessionFactory = Fluently.Configure()
                  .Database(dbConfig)
                  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<OrderManagementSystem.Areas.OMS.Models.Assets>())
                  .BuildSessionFactory();
              

            }
        }

        public UnitOfWork()
        {
            Session = _sessionFactory.OpenSession();
        }

        public void BeginTransaction()
        {
            _transaction = Session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                // commit transaction if there is one active
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                // rollback if there was an exception
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                Session.Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();
            }
            finally
            {
                Session.Dispose();
            }
        }
    }
}