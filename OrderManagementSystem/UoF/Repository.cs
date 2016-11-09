using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using NHibernate.Linq;

namespace OrderManagementSystem.UoF
{
    public class Repository<T> : IRepository<T> where T : IBaseEntity
    {
        private UnitOfWork _unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        protected ISession Session { get { return _unitOfWork.Session; } }

        public IQueryable<T> GetAll()
        {
            return Session.Query<T>();
        }

        public T GetById(int id)
        {
            return Session.Get<T>(id);
        }

        public void Create(T entity)
        {
            Type type = entity.GetType();
            //checking whether an entity is inherited from iversionedentity
            if (typeof(IVersionedEntity).IsAssignableFrom(type))
            {
                IVersionedEntity versionedEntity = (IVersionedEntity)entity;
                versionedEntity.Iscurrent = 1;
                versionedEntity.Version = 1;
                versionedEntity.Chtimestamp = DateTime.Now;
                Session.Save(versionedEntity);
                versionedEntity.Inid = versionedEntity.Id;
                Session.Save(versionedEntity);
            }
            else Session.Save(entity);
            
        }

        public void Update(T entity)
        {
            Type type = entity.GetType();
            //checking whether an entity is inherited from iversionedentity
            if (typeof(IVersionedEntity).IsAssignableFrom(type))
            {
                IVersionedEntity oldentity = (IVersionedEntity)GetById(entity.Id);
                entity.Id = 0;
                IVersionedEntity versionedEntity = (IVersionedEntity)Session.Merge((IVersionedEntity)entity);
                oldentity.Iscurrent = 0;
                versionedEntity.Version++;
                versionedEntity.Chtimestamp = DateTime.Now;
                versionedEntity.Iscurrent = 1;
                Session.Save(versionedEntity);
                Session.Save(oldentity);
            }
            else Session.Update(entity);
        }

        public void Delete(int id)
        {
            Session.Delete(Session.Load<T>(id));
        }
    }
}