using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimweighteddurationMap : ClassMap<Limweightedduration> {
        
        public LimweighteddurationMap() {
			Table("LIMWEIGHTEDDURATION");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Instruments).Column("INSTRUMENTID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Mindays).Column("MINDAYS").Not.Nullable();
			Map(x => x.Maxdays).Column("MAXDAYS").Not.Nullable();
			Map(x => x.Aimdays).Column("AIMDAYS").Not.Nullable();
			Map(x => x.Startdate).Column("STARTDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE");
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Inid).Column("INID");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
        }
    }
}
