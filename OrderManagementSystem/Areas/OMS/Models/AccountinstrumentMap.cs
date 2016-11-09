using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class AccountinstrumentMap : ClassMap<Accountinstrument> {
        
        public AccountinstrumentMap() {
			Table("ACCOUNTINSTRUMENT");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Account).Column("ACCOUNT").Not.Nullable();
			Map(x => x.Description).Column("DESCRIPTION").Not.Nullable();
        }
    }
}
