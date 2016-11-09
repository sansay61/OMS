using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimdistributionMap : ClassMap<Limdistribution> {
        
        public LimdistributionMap() {
			Table("LIMDISTRIBUTION");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Minpercent).Column("MINPERCENT").Not.Nullable();
			Map(x => x.Maxpercent).Column("MAXPERCENT").Not.Nullable();
			Map(x => x.Startdate).Column("STARTDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE");
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
			Map(x => x.Inid).Column("INID");
        }
    }
}
