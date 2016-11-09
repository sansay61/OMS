using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class InstrumenttermsMap : ClassMap<Instrumentterms> {
        
        public InstrumenttermsMap() {
			Table("INSTRUMENTTERMS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Instruments).Column("INSTRUMENTID");
			Map(x => x.Shortname).Column("SHORTNAME").Not.Nullable();
			Map(x => x.Description).Column("DESCRIPTION");
			Map(x => x.Mindays).Column("MINDAYS").Not.Nullable();
			Map(x => x.Maxdays).Column("MAXDAYS");
        }
    }
}
