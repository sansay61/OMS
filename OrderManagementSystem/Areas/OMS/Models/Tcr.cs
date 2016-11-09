using System;
using System.Text;
using System.Collections.Generic;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class Tcr {
        public virtual int Id { get; set; }
        public virtual string Sendercompid { get; set; }
        public virtual string Targetcompid { get; set; }
        public virtual long? Msgseqnum { get; set; }
        public virtual long? Targetsubid { get; set; }
        public virtual string Possdupflag { get; set; }
        public virtual DateTime? Origsendingtime { get; set; }
        public virtual DateTime? Sendingtime { get; set; }
        public virtual DateTime? Transacttime { get; set; }
        public virtual string Previouslyreported { get; set; }
        public virtual double? Lastpx { get; set; }
        public virtual DateTime? Maturitydate { get; set; }
        public virtual string Tradereportid { get; set; }
        public virtual double? Lastqty { get; set; }
        public virtual short? Pricetype { get; set; }
        public virtual short? Matchstatus { get; set; }
        public virtual DateTime? Settldate { get; set; }
        public virtual short? Tradereporttranstype { get; set; }
        public virtual string Secondarytradereportid { get; set; }
        public virtual short? Product { get; set; }
        public virtual string Trdmatchid { get; set; }
        public virtual short? Qtytype { get; set; }
        public virtual DateTime? Tradedate { get; set; }
        public virtual short? Tradereporttype { get; set; }
        public virtual string Securitytype { get; set; }
        public virtual string Securityid { get; set; }
        public virtual short? Factor { get; set; }
        public virtual double? Contractmultiplier { get; set; }
        public virtual string Securityidsource { get; set; }
        public virtual string Symbol { get; set; }
        public virtual string Yieldtype { get; set; }
        public virtual double? Yield { get; set; }
        public virtual short? Nosides { get; set; }
    }
}
