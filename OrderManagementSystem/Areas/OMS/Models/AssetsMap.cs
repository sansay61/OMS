using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class AssetsMap : ClassMap<Assets> {
        
        public AssetsMap() {
			Table("ASSETS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Subjects).Column("COUNTERPARTY");
			References(x => x.Currencies).Column("CURRID");
			Map(x => x.Ondate).Column("ONDATE");
			Map(x => x.Accname).Column("ACCNAME");
			Map(x => x.Acc).Column("ACC");
			Map(x => x.Restnom2).Column("RESTNOM2");
			Map(x => x.Restequ2).Column("RESTEQU2");
			Map(x => x.Restusd2).Column("RESTUSD2");
        }
    }
}
