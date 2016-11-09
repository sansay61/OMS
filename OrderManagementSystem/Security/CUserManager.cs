using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderManagementSystem.Security
{
    public class CUserManager : UserManager<CUser, int>
    {
        CUserStore store;
        public CUserManager(CUserStore store)
            : base(store)
        {
            this.store = store;
        }
          


        public override Task<CUser> FindAsync(string userName, string password)
        {
            string re = store.FindByNameAsync(userName).Result.Password;
            if (store.FindByNameAsync(userName).Result.Password == password)
                return store.FindByNameAsync(userName);
            else return null;
        }
        public override Task<IList<string>> GetRolesAsync(int userId)
        {
            return store.GetRolesAsync(store.FindByIdAsync(userId).Result);
        }

        public override Task<bool> IsInRoleAsync(int userId, string role)
        {
            return store.IsInRoleAsync(store.FindByIdAsync(userId).Result, role);
        }

    }
}