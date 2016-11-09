using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class Subj2ratingsMap : ClassMap<Subj2ratings> {
        
        public Subj2ratingsMap() {
			Table("SUBJ2RATINGS");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Subjects).Column("SUBJECTID");
			References(x => x.Ratings).Column("RATINGID");
        }
    }
}
