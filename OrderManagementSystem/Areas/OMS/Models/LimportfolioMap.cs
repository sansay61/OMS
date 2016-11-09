using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class LimportfolioMap : ClassMap<Limportfolio> {
        
        public LimportfolioMap() {
			Table("LIMPORTFOLIO");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Minworktotalpercent).Column("MINWORKTOTALPERCENT").Not.Nullable();
			Map(x => x.Maxinvtotalpercent).Column("MAXINVTOTALPERCENT").Not.Nullable();
			Map(x => x.Startdate).Column("STARTDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE");
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Inid).Column("INID");
        }
    }
}
