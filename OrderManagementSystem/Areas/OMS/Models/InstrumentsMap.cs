using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class InstrumentsMap : ClassMap<Instruments> {
        
        public InstrumentsMap() {
			Table("INSTRUMENTS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Portfolios).Column("PORTFOLIOID");
			References(x => x.Statuses).Column("STATUSID");
			Map(x => x.Description).Column("DESCRIPTION").Not.Nullable();
        }
    }
}
