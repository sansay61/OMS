using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class SubjecttypesMap : ClassMap<Subjecttypes> {
        
        public SubjecttypesMap() {
			Table("SUBJECTTYPES");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Description).Column("DESCRIPTION");
			Map(x => x.Shortname).Column("SHORTNAME").Not.Nullable();
        }
    }
}
