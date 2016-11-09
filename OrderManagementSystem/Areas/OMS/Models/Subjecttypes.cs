using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Subjecttypes : IEntity
    {
        public Subjecttypes() { }
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Shortname { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
