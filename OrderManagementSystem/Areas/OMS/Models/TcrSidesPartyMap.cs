using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class TcrSidesPartyMap : ClassMap<TcrSidesParty> {
        
        public TcrSidesPartyMap() {
			Table("TCR_SIDES_PARTIES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.TcrSideid).Column("TCR_SIDEID").Not.Nullable().Length(22);
			Map(x => x.Partyid).Column("PARTYID").Length(100);
			Map(x => x.Partyidsource).Column("PARTYIDSOURCE").Length(1);
			Map(x => x.Partyidrole).Column("PARTYIDROLE").Length(22);
			Map(x => x.Partyno).Column("PARTYNO").Length(22);
        }
    }
}
