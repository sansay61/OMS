using System;
using System.Text;
using System.Collections.Generic;


namespace QuickFixProcessor.Models {
    
    public class ErRefprice {
        public virtual int Id { get; set; }
        public virtual int Erid { get; set; }
        public virtual double? Refprice { get; set; }
        public virtual short? Refpricetype { get; set; }
        public virtual short? Refpricesource { get; set; }
        public virtual short? Refpriceside { get; set; }
        public virtual string Refpricetext { get; set; }
        public virtual double? Refpriceleg2 { get; set; }
        public virtual double? Refpriceforwardpoints { get; set; }
        public virtual double? Refpriceswappoints { get; set; }
        public virtual int? Refpriceno { get; set; }
    }
}
