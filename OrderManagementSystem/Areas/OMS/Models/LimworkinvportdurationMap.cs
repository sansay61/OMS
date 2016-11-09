using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimworkinvportdurationMap : ClassMap<Limworkinvportduration> {
        
        public LimworkinvportdurationMap() {
			Table("LIMWORKINVPORTDURATION");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Currencies).Column("CURRID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Minworkcurr).Column("MINWORKCURR").Not.Nullable();
			Map(x => x.Minworkportfolio).Column("MINWORKPORTFOLIO").Not.Nullable();
			Map(x => x.Maxinvcurr).Column("MAXINVCURR").Not.Nullable();
			Map(x => x.Maxinvportfolio).Column("MAXINVPORTFOLIO").Not.Nullable();
			Map(x => x.Maxduration).Column("MAXDURATION").Not.Nullable();
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
