using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimcounterpartyMap : ClassMap<Limcounterparty> {
        
        public LimcounterpartyMap() {
			Table("LIMCOUNTERPARTY");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Subjects).Column("COUNTERPARTYID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Minvolume).Column("MINVOLUME").Not.Nullable();
			Map(x => x.Maxvolume).Column("MAXVOLUME").Not.Nullable();
			Map(x => x.Startdate).Column("STARTDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE");
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
			Map(x => x.Inid).Column("INID");
        }
    }
}
