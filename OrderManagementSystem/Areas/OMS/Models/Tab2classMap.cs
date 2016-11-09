using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class Tab2classMap : ClassMap<Tab2class> {
        
        public Tab2classMap() {
			Table("TAB2CLASS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Description).Column("DESCRIPTION");
			Map(x => x.Modelname).Column("MODELNAME");
			Map(x => x.Framename).Column("FRAMENAME");
			Map(x => x.Entityname).Column("ENTITYNAME");
        }
    }
}
