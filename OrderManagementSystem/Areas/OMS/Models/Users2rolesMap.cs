using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class Users2rolesMap : ClassMap<Users2roles> {
        
        public Users2rolesMap() {
			Table("USERS2ROLES");
			Id(x => x.Id).GeneratedBy.Assigned().Column("ID");
			References(x => x.Users).Column("USERID");
			References(x => x.Roles).Column("ROLEID");
        }
    }
}
