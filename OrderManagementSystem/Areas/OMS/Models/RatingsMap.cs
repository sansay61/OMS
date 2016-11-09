using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class RatingsMap : ClassMap<Ratings> {
        
        public RatingsMap() {
			Table("RATINGS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Statuses).Column("STATUSID");
			Map(x => x.Value).Column("VALUE").Not.Nullable();
			Map(x => x.Moodys).Column("MOODYS");
			Map(x => x.Snp).Column("SNP");
			Map(x => x.Fitch).Column("FITCH");
        }
    }
}
