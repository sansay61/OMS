using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    public class Roles2priveleges:IEntity {
        public virtual int Id { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Priveleges Priveleges { get; set; }
    }
}
