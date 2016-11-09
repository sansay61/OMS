using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class TcrSide:IEntity {
        public virtual int Id { get; set; }
        public virtual int Tcrid { get; set; }
        public virtual string Side { get; set; }
        public virtual string Orderid { get; set; }
        public virtual string Secondaryorderid { get; set; }
        public virtual string Clordid { get; set; }
        public virtual string Secondaryclordid { get; set; }
        public virtual string Listid { get; set; }
        public virtual short? Nopartyids { get; set; }
        public virtual string Currency { get; set; }
        public virtual double? Grosstradeamt { get; set; }
        public virtual int? Numdaysinterest { get; set; }
        public virtual double? Accruedinterestrate { get; set; }
        public virtual double? Accruedinterestamt { get; set; }
        public virtual double? Interestatmaturity { get; set; }
        public virtual double? Netmoney { get; set; }
        public virtual decimal? Settlcurrency { get; set; }
        public virtual string Text { get; set; }
        public virtual int? Sideno { get; set; }
    }
}
