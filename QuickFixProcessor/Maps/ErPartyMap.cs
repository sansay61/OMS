using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using QuickFixProcessor.Models; 

namespace QuickFixProcessor.Maps {
    
    
    public class ErPartyMap : ClassMap<ErParty> {
        
        public ErPartyMap() {
			Table("ER_PARTIES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Erid).Column("ERID").Not.Nullable().Length(22);
			Map(x => x.Partyid).Column("PARTYID").Length(100);
			Map(x => x.Partyidsource).Column("PARTYIDSOURCE").Length(1);
			Map(x => x.Partyidrole).Column("PARTYIDROLE").Length(22);
			Map(x => x.Partyno).Column("PARTYNO").Length(22);
        }
    }
}
