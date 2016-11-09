using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class TcrSideMap : ClassMap<TcrSide> {
        
        public TcrSideMap() {
			Table("TCR_SIDES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Tcrid).Column("TCRID").Not.Nullable().Length(22);
			Map(x => x.Side).Column("SIDE").Not.Nullable().Length(100);
			Map(x => x.Orderid).Column("ORDERID").Length(100);
			Map(x => x.Secondaryorderid).Column("SECONDARYORDERID").Length(100);
			Map(x => x.Clordid).Column("CLORDID").Length(100);
			Map(x => x.Secondaryclordid).Column("SECONDARYCLORDID").Length(100);
			Map(x => x.Listid).Column("LISTID").Length(100);
			Map(x => x.Nopartyids).Column("NOPARTYIDS").Length(22);
			Map(x => x.Currency).Column("CURRENCY").Length(3);
			Map(x => x.Grosstradeamt).Column("GROSSTRADEAMT").Length(22);
			Map(x => x.Numdaysinterest).Column("NUMDAYSINTEREST").Length(22);
			Map(x => x.Accruedinterestrate).Column("ACCRUEDINTERESTRATE").Length(22);
			Map(x => x.Accruedinterestamt).Column("ACCRUEDINTERESTAMT").Length(22);
			Map(x => x.Interestatmaturity).Column("INTERESTATMATURITY").Length(22);
			Map(x => x.Netmoney).Column("NETMONEY").Length(22);
			Map(x => x.Settlcurrency).Column("SETTLCURRENCY").Length(22);
			Map(x => x.Text).Column("TEXT").Length(100);
			Map(x => x.Sideno).Column("SIDENO").Length(22);
        }
    }
}
