using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    public class Depts:IEntity {
        public Depts() { }
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
    }
}
