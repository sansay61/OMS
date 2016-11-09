using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Currencies : IEntity
    {
        public Currencies() { }
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual string Iso { get; set; }
        public virtual int? Decimalplaces { get; set; }
        public virtual short? Isactive { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
