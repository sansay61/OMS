using Microsoft.AspNet.Identity;
using OrderManagementSystem.Areas.OMS.Models;
using OrderManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;

namespace OrderManagementSystem.Security
{
    public class CUser : IUser<int>
    
    {

        public CUser ()
        {
            SecurityStamp = Guid.NewGuid().ToString();
        }

        
        public int Id { get; set; }
        public string UserName { get; set; }
        public string SecurityStamp { get; set; }
        public string Password { get; set; }
        public List<string> Roles { get; set; }
        public string Email { get; set; }
    }
}