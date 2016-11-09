using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class Roles2privelegesMap : ClassMap<Roles2priveleges> {
        
        public Roles2privelegesMap() {
			Table("ROLES2PRIVELEGES");
			Id(x => x.Id).GeneratedBy.Assigned().Column("ID");
			References(x => x.Roles).Column("ROLEID");
			References(x => x.Priveleges).Column("PRIVELEGEID");
        }
    }
}
