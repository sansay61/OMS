using Microsoft.AspNet.Identity;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.UoF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OrderManagementSystem.Security
{
    public class CRoleStore : IRoleStore<CRole, int>
    {
        Repository<Roles> repo;
        public CRoleStore(IUnitOfWork unitofwork) 
        {
            repo = new Repository<Roles>(unitofwork);
        }
        public Task CreateAsync(CRole role)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(CRole role)
        {
            throw new NotImplementedException();
        }
        public Task<CRole> FindByIdAsync(int roleId)
        {
            return Task<CRole>.Factory.StartNew(() => toCRole(repo.GetById(roleId)));
        }
        public Task<CRole> FindByNameAsync(string roleName)
        {
            return Task<CRole>.Factory.StartNew(() => toCRole(repo.GetAll().ToList().FirstOrDefault(n => n.Description == roleName)));
        }
        public Task UpdateAsync(CRole role)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        private CRole toCRole(Roles role)
        {
            CRole crole = new CRole();
            crole.Id = role.Id;
            crole.Name = role.Description;
            return crole;
        }
    }
}