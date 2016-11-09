using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Instrumentterms : IEntity
    {
        public Instrumentterms() { }
        public virtual int Id { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual string Shortname { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Mindays { get; set; }
        public virtual decimal? Maxdays { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
