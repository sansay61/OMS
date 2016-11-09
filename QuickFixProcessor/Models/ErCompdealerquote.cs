using System;
using System.Text;
using System.Collections.Generic;


namespace QuickFixProcessor.Models {
    
    public class ErCompdealerquote {
        public virtual int Id { get; set; }
        public virtual double Erid { get; set; }
        public virtual string Compdealerid { get; set; }
        public virtual double? Compdealerquoteprice { get; set; }
        public virtual short? Compdealerquotepricetype { get; set; }
        public virtual double? Compdealerparquote { get; set; }
        public virtual double? Dealernetmoney { get; set; }
        public virtual double? Compdealerquotepriceleg2 { get; set; }
        public virtual double? Compdealerquoteforwardpoints { get; set; }
        public virtual double? Compdealerquoteswappoints { get; set; }
        public virtual double? Compdealerquoteordqty { get; set; }
        public virtual double? Compdealerquoteno { get; set; }
    }
}
