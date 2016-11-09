using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Instruments : IEntity
    {
        public Instruments() { }
        public virtual int Id { get; set; }
        public virtual Portfolios Portfolios { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
