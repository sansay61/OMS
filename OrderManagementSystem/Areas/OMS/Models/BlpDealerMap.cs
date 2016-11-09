using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class BlpDealerMap : ClassMap<BlpDealer> {
        
        public BlpDealerMap() {
			Table("BLP_DEALERS");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Fullname).Column("FULLNAME").Length(100);
			Map(x => x.BlpName).Column("BLP_NAME").Length(100);
			Map(x => x.BlpCode).Column("BLP_CODE").Length(22);
        }
    }
}
