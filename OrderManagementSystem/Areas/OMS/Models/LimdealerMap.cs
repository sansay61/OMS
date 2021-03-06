using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimdealerMap : ClassMap<Limdealer> {
        
        public LimdealerMap() {
			Table("LIMDEALER");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Currencies).Column("CURRID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Volume).Column("VOLUME").Not.Nullable();
			Map(x => x.Duration).Column("DURATION").Not.Nullable();
			Map(x => x.Notes).Column("NOTES");
			Map(x => x.Startdate).Column("STARTDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE");
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
			Map(x => x.Inid).Column("INID");
        }
    }
}
