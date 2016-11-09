using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class ErSecuritiesaltidMap : ClassMap<ErSecuritiesaltid> {
        
        public ErSecuritiesaltidMap() {
			Table("ER_SECURITIESALTID");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Erid).Column("ERID").Not.Nullable().Length(22);
			Map(x => x.Securityaltid).Column("SECURITYALTID").Length(50);
			Map(x => x.Securityaltidsource).Column("SECURITYALTIDSOURCE").Length(22);
			Map(x => x.Securityaltidno).Column("SECURITYALTIDNO").Length(22);
        }
    }
}
