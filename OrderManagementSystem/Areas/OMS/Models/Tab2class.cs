using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Tab2class : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Modelname { get; set; }
        public virtual string Framename { get; set; }
        public virtual string Entityname { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
