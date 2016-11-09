using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using QuickFixProcessor.Models; 

namespace QuickFixProcessor.Maps {
    
    
    public class TcrSidesPartiesSubMap : ClassMap<TcrSidesPartiesSub> {
        
        public TcrSidesPartiesSubMap() {
			Table("TCR_SIDES_PARTIES_SUB");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.TcrSidesPartyid).Column("TCR_SIDES_PARTYID").Not.Nullable().Length(22);
			Map(x => x.Partysubid).Column("PARTYSUBID").Length(100);
			Map(x => x.Partysubidtype).Column("PARTYSUBIDTYPE").Length(100);
			Map(x => x.Partysubno).Column("PARTYSUBNO").Length(22);
        }
    }
}
