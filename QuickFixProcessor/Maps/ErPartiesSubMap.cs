using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using QuickFixProcessor.Models; 

namespace QuickFixProcessor.Maps {
    
    
    public class ErPartiesSubMap : ClassMap<ErPartiesSub> {
        
        public ErPartiesSubMap() {
			Table("ER_PARTIES_SUB");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.ErPartyid).Column("ER_PARTYID").Not.Nullable().Length(22);
			Map(x => x.Partysubid).Column("PARTYSUBID").Length(100);
			Map(x => x.Partysubidtype).Column("PARTYSUBIDTYPE").Length(100);
			Map(x => x.Partysubno).Column("PARTYSUBNO").Length(22);
        }
    }
}
