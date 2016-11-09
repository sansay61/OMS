using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class CurrenciesMap : ClassMap<Currencies> {
        
        public CurrenciesMap() {
			Table("CURRENCIES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Description).Column("DESCRIPTION").Not.Nullable();
			Map(x => x.Iso).Column("ISO").Not.Nullable();
			Map(x => x.Decimalplaces).Column("DECIMALPLACES");
			Map(x => x.Isactive).Column("ISACTIVE");
        }
    }
}
