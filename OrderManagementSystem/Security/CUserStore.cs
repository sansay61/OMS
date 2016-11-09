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
    public class CUserStore : IUserStore<CUser, int>, IUserPasswordStore<CUser, int>, IUserSecurityStampStore<CUser, int>,IUserRoleStore<CUser,int>,IUserClaimStore<CUser,int>
    {
        private Repository<Users> repo;
        Repository<Users2roles> users2rolesRepo;
        Repository<Roles> rolesRepo;
        Repository<Users> usersRepo;
        public CUserStore(IUnitOfWork UnitOfWork)
        {
            // TODO: Complete member initialization
            repo = new Repository<Users>((UnitOfWork)UnitOfWork);
            users2rolesRepo = new Repository<Users2roles>((UnitOfWork)UnitOfWork);
            rolesRepo = new Repository<Roles>((UnitOfWork)UnitOfWork);
            usersRepo = new Repository<Users>((UnitOfWork)UnitOfWork);
        }

        
        
       

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task CreateAsync(CUser user)
        {
            //return Task.Factory.StartNew(() => cusers.Add(user));
            return null;
        }

        public Task UpdateAsync(CUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CUser user)
        {
            throw new NotImplementedException();
        }

        public Task<CUser> FindByIdAsync(int userId)
        {
            return Task<CUser>.Factory.StartNew(() => toCUser(repo.GetById(userId)));
        }

        public Task<CUser> FindByNameAsync(string userName)
        {
            return Task<CUser>.Factory.StartNew(() => toCUser(repo.GetAll().ToList().FirstOrDefault(u => u.Login == userName)));
        }
        public Task<string> GetPasswordHashAsync(CUser user)
        {
            var task = Task<string>.Factory.StartNew(() => repo.GetById(user.Id).Password);
            return task;
        }

        public Task<bool> HasPasswordAsync(CUser user)
        {
            var task = Task<bool>.Factory.StartNew(() => repo.GetById(user.Id).Password==null?false:true);
            user.Password = repo.GetById(user.Id).Password;
            return task;
        }

        public Task SetPasswordHashAsync(CUser user, string passwordHash)
        {
            // var task = userStore.SetPasswordHashAsync(identityUser, passwordHash);
            //SetApplicationUser(user, identityUser);
            return null;
        }

        public Task<string> GetSecurityStampAsync(CUser user)
        {
            return null;
        }

        public Task SetSecurityStampAsync(CUser user, string stamp)
        {
            return null;
        }


        private CUser toCUser(Users user)
        {
            CUser cuser=new CUser();
            cuser.Password = user.Password;
            cuser.Id = user.Id;
            cuser.UserName=user.Login;
            cuser.SecurityStamp=Guid.NewGuid().ToString();
            return cuser;
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


        public Task AddClaimAsync(CUser user, System.Security.Claims.Claim claim)
        {
            throw new NotImplementedException();
        }

        public Task<IList<System.Security.Claims.Claim>> GetClaimsAsync(CUser user)
        {
            throw new NotImplementedException();
        }

        public Task RemoveClaimAsync(CUser user, System.Security.Claims.Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}
