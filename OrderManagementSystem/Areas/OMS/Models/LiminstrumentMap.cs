using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LiminstrumentMap : ClassMap<Liminstrument> {
        
        public LiminstrumentMap() {
			Table("LIMINSTRUMENT");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Instruments).Column("INSTRUMENTID");
			References(x => x.Instrumentterms).Column("INSTRUMENTTERMID");
			References(x => x.Currencies).Column("CURRID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Aimpercent).Column("AIMPERCENT").Not.Nullable();
			Map(x => x.Maxduration).Column("MAXDURATION").Not.Nullable();
			Map(x => x.Startdate).Column("STARTDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE");
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
			Map(x => x.Inid).Column("INID");
        }
    }
}
