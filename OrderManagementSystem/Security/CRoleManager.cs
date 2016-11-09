using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.Security
{
    public class CRoleManager:RoleManager<CRole,int>
    {
        public CRoleManager(IRoleStore<CRole, int> roleStore)
        : base(roleStore)
    {
    }

  
    }
}