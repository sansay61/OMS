using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class DeptsMap : ClassMap<Depts> {
        
        public DeptsMap() {
			Table("DEPTS");
			Id(x => x.Id).GeneratedBy.Assigned().Column("ID");
			Map(x => x.Description).Column("DESCRIPTION").Length(100);
        }
    }
}
