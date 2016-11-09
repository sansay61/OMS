using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class OperationsMap : ClassMap<Operations> {
        
        public OperationsMap() {
			Table("OPERATIONS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Instruments).Column("INSTRUMENTID");
			References(x => x.Statuses).Column("STATUSID");
			Map(x => x.Description).Column("DESCRIPTION").Not.Nullable();
			Map(x => x.Shortname).Column("SHORTNAME").Not.Nullable();
        }
    }
}
