using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class FixSecurityidsourceMap : ClassMap<FixSecurityidsource> {
        
        public FixSecurityidsourceMap() {
			Table("FIX_SECURITYIDSOURCE");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Value).Column("VALUE").Unique().Length(1);
			Map(x => x.Description).Column("DESCRIPTION").Length(50);
        }
    }
}
