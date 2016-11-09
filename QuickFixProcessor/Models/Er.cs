using System;
using System.Text;
using System.Collections.Generic;


namespace QuickFixProcessor.Models {
    
    public class Er {
        public virtual int Id { get; set; }
        public virtual string Sendercompid { get; set; }
        public virtual string Targetcompid { get; set; }
        public virtual long? Msgseqnum { get; set; }
        public virtual DateTime? Origsendingtime { get; set; }
        public virtual DateTime? Sendingtime { get; set; }
        public virtual DateTime? Transacttime { get; set; }
        public virtual string Settlcurrency { get; set; }
        public virtual string Exectype { get; set; }
        public virtual double? Lastpx { get; set; }
        public virtual double? Leavesqty { get; set; }
        public virtual DateTime? Maturitydate { get; set; }
        public virtual double? Lastqty { get; set; }
        public virtual int? Pricetype { get; set; }
        public virtual DateTime? Settldate { get; set; }
        public virtual double? Avgpx { get; set; }
        public virtual int? Numdaysinterest { get; set; }
        public virtual double? Calculatedccylastqty { get; set; }
        public virtual string Orderid { get; set; }
        public virtual string Agressorindicator { get; set; }
        public virtual double? Orderqty { get; set; }
        public virtual double? Spread { get; set; }
        public virtual string Ordstatus { get; set; }
        public virtual double? Accruedinterestamount { get; set; }
        public virtual string Ordtype { get; set; }
        public virtual double? Lastparpx { get; set; }
        public virtual short? Product { get; set; }
        public virtual double? Couponrate { get; set; }
        public virtual string Clordid { get; set; }
        public virtual double? Cumqty { get; set; }
        public virtual double? Lastspotrate { get; set; }
        public virtual short? Qtytype { get; set; }
        public virtual string Currency { get; set; }
        public virtual DateTime? Tradedate { get; set; }
        public virtual string Issuer { get; set; }
        public virtual double? Lastforwardpoints { get; set; }
        public virtual string Execid { get; set; }
        public virtual string Securitytype { get; set; }
        public virtual string Securityid { get; set; }
        public virtual string Secondaryorderid { get; set; }
        public virtual string Countryofissue { get; set; }
        public virtual double? Grosstradeamt { get; set; }
        public virtual string Securityidsource { get; set; }
        public virtual double? Benchmarkyield { get; set; }
        public virtual double? Assetswapspread { get; set; }
        public virtual string Copymsgindicator { get; set; }
        public virtual short? Side { get; set; }
        public virtual double? Ispread { get; set; }
        public virtual short? Recipientrole { get; set; }
        public virtual string Symbol { get; set; }
        public virtual double? Zspread { get; set; }
        public virtual double? Yield { get; set; }
        public virtual double? Netmoney { get; set; }
        public virtual double? Settlcurramt { get; set; }
        public virtual short? Nolegs { get; set; }
        public virtual short? Nocompdealerquotes { get; set; }
        public virtual short? Nopartyids { get; set; }
        public virtual short? Nonotes { get; set; }
        public virtual short? Nosecurityaltid { get; set; }
        public virtual short? Norefprices { get; set; }
        public virtual short? Coupondaycount { get; set; }
        public virtual string Actiontype { get; set; }
        public virtual string Execrefid { get; set; }
    }
}
