using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class DepositsMap : ClassMap<Deposits> {
        
        public DepositsMap() {
			Table("DEPOSITS");
			LazyLoad();
			Id(x => x.Id, "ID").GeneratedBy.Increment();
			References(x => x.Operations).Column("OPERATIONID");
			References(x => x.Subjects).Column("COUNTERPARTYID");
			References(x => x.Currencies).Column("CURRID");
			References(x => x.Instrumentterms).Column("INSTRUMENTTERMID");
			References(x => x.Statuses).Column("STATUSID");
			References(x => x.User).Column("CHUSERID");
			Map(x => x.Amount).Column("AMOUNT").Not.Nullable();
			Map(x => x.Yeild).Column("YEILD");
			Map(x => x.Regdate).Column("REGDATE").Not.Nullable();
			Map(x => x.Valdate).Column("VALDATE").Not.Nullable();
			Map(x => x.Enddate).Column("ENDDATE").Not.Nullable();
			Map(x => x.Usdeq).Column("USDEQ");
			Map(x => x.Basis).Column("BASIS").Not.Nullable();
			Map(x => x.Version).Column("VERSION");
			Map(x => x.Iscurrent).Column("ISCURRENT");
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP");
            Map(x => x.Inid).Column("INID");
            
            

        }
    }
}
