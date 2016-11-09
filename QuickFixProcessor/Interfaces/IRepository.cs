using System;
using System.Collections.Generic;using QuickFixProcessor.Interfaces;
using System.Linq;
using System.Web;

namespace QuickFixProcessor.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }

}