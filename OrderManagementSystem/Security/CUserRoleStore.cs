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
    public class CUserRoleStore : IUserRoleStore<CUser, int>
    {
        Repository<Users2roles> users2rolesRepo;
        Repository<Roles> rolesRepo;
        Repository<Users> usersRepo;
        public CUserRoleStore(IUnitOfWork unitofwork)
        {
            users2rolesRepo = new Repository<Users2roles>(unitofwork);
            rolesRepo = new Repository<Roles>(unitofwork);
            usersRepo = new Repository<Users>(unitofwork);
        }

        public Task AddToRoleAsync(CUser user, string roleName)
        {
            Users2roles u2r=new Users2roles();
            Users userid=usersRepo.GetById(user.Id);
            Roles roleid=rolesRepo.GetAll().ToList().FirstOrDefault(n=>n.Description==roleName);
            u2r.Roles=roleid;
            u2r.Users=userid;
            return Task.Factory.StartNew(()=>users2rolesRepo.Create(u2r));
        }

        public Task<IList<string>> GetRolesAsync(CUser user)
        {
            IList<string> retarray = users2rolesRepo.GetAll().ToList().FindAll(n => n.Users.Id == user.Id).Select(x => x.Roles.Description).ToList();
            return Task<IList<string>>.Factory.StartNew(() => retarray);
        }

        public Task<bool> IsInRoleAsync(CUser user, string roleName)
        {
            var roles = GetRolesAsync(user);
            return Task<bool>.Factory.StartNew(() => roles.Result.FirstOrDefault(r => r == roleName)!=null?true:false);
        }

        public Task RemoveFromRoleAsync(CUser user, string roleName)
        {
            Users2roles u2r = users2rolesRepo.GetAll().Where(a => a.Roles.Description == roleName && a.Users.Login == user.UserName).First();
            if (u2r!=null)
                return Task.Factory.StartNew(() => users2rolesRepo.Delete(u2r.Id));
            return null;
        }

        public Task CreateAsync(CUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CUser user)
        {
            throw new NotImplementedException();
        }

        Task<CUser> IUserStore<CUser, int>.FindByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        Task<CUser> IUserStore<CUser, int>.FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }
    }
}