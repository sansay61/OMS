using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class SubjectsMap : ClassMap<Subjects> {
        
        public SubjectsMap() {
			Table("SUBJECTS");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Statuses).Column("STATUSID");
			References(x => x.Subjecttypes).Column("SUBJECTTYPEID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Opendate).Column("OPENDATE").Not.Nullable();
			Map(x => x.Closedate).Column("CLOSEDATE");
			Map(x => x.Shortname).Column("SHORTNAME").Not.Nullable();
			Map(x => x.Subjectname).Column("SUBJECTNAME").Not.Nullable();
			Map(x => x.Internationalname).Column("INTERNATIONALNAME").Not.Nullable();
            Map(x => x.Version).Column("VERSION");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
			Map(x => x.Inid).Column("INID");
        }
    }
}
