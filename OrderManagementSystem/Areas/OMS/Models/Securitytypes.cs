using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Securitytypes : IEntity
    {
        public Securitytypes() { }
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }
}
