using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using QuickFixProcessor.Models; 

namespace QuickFixProcessor.Maps {
    
    
    public class ErCompdealerquoteMap : ClassMap<ErCompdealerquote> {
        
        public ErCompdealerquoteMap() {
			Table("ER_COMPDEALERQUOTES");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Erid).Column("ERID").Not.Nullable().Length(22);
			Map(x => x.Compdealerid).Column("COMPDEALERID").Length(50);
			Map(x => x.Compdealerquoteprice).Column("COMPDEALERQUOTEPRICE").Length(22);
			Map(x => x.Compdealerquotepricetype).Column("COMPDEALERQUOTEPRICETYPE").Length(22);
			Map(x => x.Compdealerparquote).Column("COMPDEALERPARQUOTE").Length(22);
			Map(x => x.Dealernetmoney).Column("DEALERNETMONEY").Length(22);
			Map(x => x.Compdealerquotepriceleg2).Column("COMPDEALERQUOTEPRICELEG2").Length(22);
			Map(x => x.Compdealerquoteforwardpoints).Column("COMPDEALERQUOTEFORWARDPOINTS").Length(22);
			Map(x => x.Compdealerquoteswappoints).Column("COMPDEALERQUOTESWAPPOINTS").Length(22);
			Map(x => x.Compdealerquoteordqty).Column("COMPDEALERQUOTEORDQTY").Length(22);
			Map(x => x.Compdealerquoteno).Column("COMPDEALERQUOTENO").Length(22);
        }
    }
}
