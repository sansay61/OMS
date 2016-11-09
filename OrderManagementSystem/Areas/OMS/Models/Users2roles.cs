using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    public class Users2roles:IEntity {
        public virtual int Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
