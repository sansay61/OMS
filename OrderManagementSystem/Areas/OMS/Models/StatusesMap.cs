using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class StatusesMap : ClassMap<Statuses> {
        
        public StatusesMap() {
			Table("STATUSES");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Description).Column("DESCRIPTION").Not.Nullable();
        }
    }
}
