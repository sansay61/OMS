using System;
using System.Text;
using System.Collections.Generic;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class ErPartiesSub {
        public virtual int Id { get; set; }
        public virtual int ErPartyid { get; set; }
        public virtual string Partysubid { get; set; }
        public virtual string Partysubidtype { get; set; }
        public virtual int? Partysubno { get; set; }
    }
}
