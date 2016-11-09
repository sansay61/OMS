using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class ErRefpriceMap : ClassMap<ErRefprice> {
        
        public ErRefpriceMap() {
			Table("ER_REFPRICES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Erid).Column("ERID").Not.Nullable().Length(22);
			Map(x => x.Refprice).Column("REFPRICE").Length(22);
			Map(x => x.Refpricetype).Column("REFPRICETYPE").Length(22);
			Map(x => x.Refpricesource).Column("REFPRICESOURCE").Length(22);
			Map(x => x.Refpriceside).Column("REFPRICESIDE").Length(22);
			Map(x => x.Refpricetext).Column("REFPRICETEXT").Length(100);
			Map(x => x.Refpriceleg2).Column("REFPRICELEG2").Length(22);
			Map(x => x.Refpriceforwardpoints).Column("REFPRICEFORWARDPOINTS").Length(22);
			Map(x => x.Refpriceswappoints).Column("REFPRICESWAPPOINTS").Length(22);
			Map(x => x.Refpriceno).Column("REFPRICENO").Length(22);
        }
    }
}
