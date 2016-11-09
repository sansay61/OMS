using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class SecuritytypesMap : ClassMap<Securitytypes> {
        
        public SecuritytypesMap() {
			Table("SECURITYTYPES");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Description).Column("DESCRIPTION").Not.Nullable();
        }
    }
}
