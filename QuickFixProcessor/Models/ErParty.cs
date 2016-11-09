using System;
using System.Text;
using System.Collections.Generic;


namespace QuickFixProcessor.Models {
    
    public class ErParty {
        public virtual int Id { get; set; }
        public virtual int Erid { get; set; }
        public virtual string Partyid { get; set; }
        public virtual string Partyidsource { get; set; }
        public virtual short? Partyidrole { get; set; }
        public virtual int? Partyno { get; set; }
    }
}
