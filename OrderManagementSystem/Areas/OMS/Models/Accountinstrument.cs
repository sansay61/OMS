using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    public class Accountinstrument:IEntity {
        public virtual int Id { get; set; }
        public virtual string Account { get; set; }
        public virtual string Description { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }
}
