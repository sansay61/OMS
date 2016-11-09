using System;
using System.Text;
using System.Collections.Generic;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class ErSecuritiesaltid {
        public virtual int Id { get; set; }
        public virtual int Erid { get; set; }
        public virtual string Securityaltid { get; set; }
        public virtual string Securityaltidsource { get; set; }
        public virtual int? Securityaltidno { get; set; }
    }
}
