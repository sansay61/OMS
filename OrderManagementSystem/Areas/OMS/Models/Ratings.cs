using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Ratings : IEntity
    {
        public Ratings() { }
        public virtual int Id { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual decimal Value { get; set; }
        public virtual string Moodys { get; set; }
        public virtual string Snp { get; set; }
        public virtual string Fitch { get; set; }

        public override string ToString()
        {
            return "Moodys=" + Moodys+"; SNP="+Snp+"; Fitch="+Fitch ;
        }
    }
}
