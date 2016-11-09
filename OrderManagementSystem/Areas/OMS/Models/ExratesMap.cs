using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class ExratesMap : ClassMap<Exrates> {
        
        public ExratesMap() {
			Table("EXRATES");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Currencies).Column("CURRID");
			Map(x => x.Pricedate).Column("PRICEDATE");
			Map(x => x.Price).Column("PRICE");
        }
    }
}
