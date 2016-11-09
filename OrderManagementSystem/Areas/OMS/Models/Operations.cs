using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Operations : IEntity
    {
        public Operations() { }
        public virtual int Id { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual string Description { get; set; }
        public virtual string Shortname { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
