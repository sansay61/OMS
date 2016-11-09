using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class ErMap : ClassMap<Er> {
        
        public ErMap() {
			Table("ER");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Sendercompid).Column("SENDERCOMPID").Length(50);
			Map(x => x.Targetcompid).Column("TARGETCOMPID").Length(50);
			Map(x => x.Msgseqnum).Column("MSGSEQNUM").Length(22);
			Map(x => x.Origsendingtime).Column("ORIGSENDINGTIME").Length(7);
			Map(x => x.Sendingtime).Column("SENDINGTIME").Length(7);
			Map(x => x.Transacttime).Column("TRANSACTTIME").Length(7);
			Map(x => x.Settlcurrency).Column("SETTLCURRENCY").Length(3);
			Map(x => x.Exectype).Column("EXECTYPE").Length(1);
			Map(x => x.Lastpx).Column("LASTPX").Length(22);
			Map(x => x.Leavesqty).Column("LEAVESQTY").Length(22);
			Map(x => x.Maturitydate).Column("MATURITYDATE").Length(7);
			Map(x => x.Lastqty).Column("LASTQTY").Length(22);
			Map(x => x.Pricetype).Column("PRICETYPE").Length(22);
			Map(x => x.Settldate).Column("SETTLDATE").Length(7);
			Map(x => x.Avgpx).Column("AVGPX").Length(22);
			Map(x => x.Numdaysinterest).Column("NUMDAYSINTEREST").Length(22);
			Map(x => x.Calculatedccylastqty).Column("CALCULATEDCCYLASTQTY").Length(22);
			Map(x => x.Orderid).Column("ORDERID").Length(100);
			Map(x => x.Agressorindicator).Column("AGRESSORINDICATOR").Length(1);
			Map(x => x.Orderqty).Column("ORDERQTY").Length(22);
			Map(x => x.Spread).Column("SPREAD").Length(22);
			Map(x => x.Ordstatus).Column("ORDSTATUS").Length(1);
			Map(x => x.Accruedinterestamount).Column("ACCRUEDINTERESTAMOUNT").Length(22);
			Map(x => x.Ordtype).Column("ORDTYPE").Length(1);
			Map(x => x.Lastparpx).Column("LASTPARPX").Length(22);
			Map(x => x.Product).Column("PRODUCT").Length(22);
			Map(x => x.Couponrate).Column("COUPONRATE").Length(22);
			Map(x => x.Clordid).Column("CLORDID").Length(100);
			Map(x => x.Cumqty).Column("CUMQTY").Length(22);
			Map(x => x.Lastspotrate).Column("LASTSPOTRATE").Length(22);
			Map(x => x.Qtytype).Column("QTYTYPE").Length(22);
			Map(x => x.Currency).Column("CURRENCY").Length(3);
			Map(x => x.Tradedate).Column("TRADEDATE").Length(7);
			Map(x => x.Issuer).Column("ISSUER").Length(100);
			Map(x => x.Lastforwardpoints).Column("LASTFORWARDPOINTS").Length(22);
			Map(x => x.Execid).Column("EXECID").Length(100);
			Map(x => x.Securitytype).Column("SECURITYTYPE").Length(32);
			Map(x => x.Securityid).Column("SECURITYID").Length(50);
			Map(x => x.Secondaryorderid).Column("SECONDARYORDERID").Length(100);
			Map(x => x.Countryofissue).Column("COUNTRYOFISSUE").Length(50);
			Map(x => x.Grosstradeamt).Column("GROSSTRADEAMT").Length(22);
			Map(x => x.Securityidsource).Column("SECURITYIDSOURCE").Length(1);
			Map(x => x.Benchmarkyield).Column("BENCHMARKYIELD").Length(22);
			Map(x => x.Assetswapspread).Column("ASSETSWAPSPREAD").Length(22);
			Map(x => x.Copymsgindicator).Column("COPYMSGINDICATOR").Length(1);
			Map(x => x.Side).Column("SIDE").Length(22);
			Map(x => x.Ispread).Column("ISPREAD").Length(22);
			Map(x => x.Recipientrole).Column("RECIPIENTROLE").Length(22);
			Map(x => x.Symbol).Column("SYMBOL").Length(100);
			Map(x => x.Zspread).Column("ZSPREAD").Length(22);
			Map(x => x.Yield).Column("YIELD").Length(22);
			Map(x => x.Netmoney).Column("NETMONEY").Length(22);
			Map(x => x.Settlcurramt).Column("SETTLCURRAMT").Length(22);
			Map(x => x.Nolegs).Column("NOLEGS").Length(22);
			Map(x => x.Nocompdealerquotes).Column("NOCOMPDEALERQUOTES").Length(22);
			Map(x => x.Nopartyids).Column("NOPARTYIDS").Length(22);
			Map(x => x.Nonotes).Column("NONOTES").Length(22);
			Map(x => x.Nosecurityaltid).Column("NOSECURITYALTID").Length(22);
			Map(x => x.Norefprices).Column("NOREFPRICES").Length(22);
			Map(x => x.Coupondaycount).Column("COUPONDAYCOUNT").Length(22);
            Map(x => x.Actiontype).Column("ACTIONTYPE").Length(1);
            Map(x => x.Execrefid).Column("EXECREFID").Length(100);
        }
    }
}
