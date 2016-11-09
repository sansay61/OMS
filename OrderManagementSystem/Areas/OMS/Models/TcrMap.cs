using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class TcrMap : ClassMap<Tcr> {
        
        public TcrMap() {
			Table("TCR");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Sendercompid).Column("SENDERCOMPID").Length(50);
			Map(x => x.Targetcompid).Column("TARGETCOMPID").Length(50);
			Map(x => x.Msgseqnum).Column("MSGSEQNUM").Length(22);
			Map(x => x.Targetsubid).Column("TARGETSUBID").Length(22);
			Map(x => x.Possdupflag).Column("POSSDUPFLAG").Length(1);
			Map(x => x.Origsendingtime).Column("ORIGSENDINGTIME").Length(7);
			Map(x => x.Sendingtime).Column("SENDINGTIME").Length(7);
			Map(x => x.Transacttime).Column("TRANSACTTIME").Length(7);
			Map(x => x.Previouslyreported).Column("PREVIOUSLYREPORTED").Length(1);
			Map(x => x.Lastpx).Column("LASTPX").Length(22);
			Map(x => x.Maturitydate).Column("MATURITYDATE").Length(7);
			Map(x => x.Tradereportid).Column("TRADEREPORTID").Length(100);
			Map(x => x.Lastqty).Column("LASTQTY").Length(22);
			Map(x => x.Pricetype).Column("PRICETYPE").Length(22);
			Map(x => x.Matchstatus).Column("MATCHSTATUS").Length(22);
			Map(x => x.Settldate).Column("SETTLDATE").Length(7);
			Map(x => x.Tradereporttranstype).Column("TRADEREPORTTRANSTYPE").Length(22);
			Map(x => x.Secondarytradereportid).Column("SECONDARYTRADEREPORTID").Length(100);
			Map(x => x.Product).Column("PRODUCT").Length(22);
			Map(x => x.Trdmatchid).Column("TRDMATCHID").Length(100);
			Map(x => x.Qtytype).Column("QTYTYPE").Length(22);
			Map(x => x.Tradedate).Column("TRADEDATE").Length(7);
			Map(x => x.Tradereporttype).Column("TRADEREPORTTYPE").Length(22);
			Map(x => x.Securitytype).Column("SECURITYTYPE").Length(50);
			Map(x => x.Securityid).Column("SECURITYID").Length(50);
			Map(x => x.Factor).Column("FACTOR").Length(22);
			Map(x => x.Contractmultiplier).Column("CONTRACTMULTIPLIER").Length(22);
			Map(x => x.Securityidsource).Column("SECURITYIDSOURCE").Length(22);
			Map(x => x.Symbol).Column("SYMBOL").Length(100);
			Map(x => x.Yieldtype).Column("YIELDTYPE").Length(50);
			Map(x => x.Yield).Column("YIELD").Length(22);
			Map(x => x.Nosides).Column("NOSIDES").Length(22);
        }
    }
}
