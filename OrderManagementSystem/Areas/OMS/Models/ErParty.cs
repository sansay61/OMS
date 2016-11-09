using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class ErParty:IEntity {
        public virtual int Id { get; set; }
        public virtual int Erid { get; set; }
        public virtual string Partyid { get; set; }
        public virtual string Partyidsource { get; set; }
        public virtual short? Partyidrole { get; set; }
        public virtual int? Partyno { get; set; }
    }
}
