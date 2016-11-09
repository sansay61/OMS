using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimdistrcptypeMap : ClassMap<Limdistrcptype> {
        
        public LimdistrcptypeMap() {
			Table("LIMDISTRCPTYPE");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Instruments).Column("INSTRUMENTID");
			References(x => x.Subjecttypes).Column("COUNTERPARTYTYPEID");
			References(x => x.Limdistribution).Column("LIM_ID");
        }
    }
}
