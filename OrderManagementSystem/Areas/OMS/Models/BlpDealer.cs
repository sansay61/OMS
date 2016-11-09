using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class BlpDealer:IEntity {
        public virtual int Id { get; set; }
        public virtual string Fullname { get; set; }
        public virtual string BlpName { get; set; }
        public virtual decimal? BlpCode { get; set; }
    }
}
