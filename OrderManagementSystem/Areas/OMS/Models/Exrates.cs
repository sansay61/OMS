using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Exrates : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual DateTime? Pricedate { get; set; }
        public virtual decimal? Price { get; set; }

        public override string ToString()
        {
            return Pricedate.ToString();
        }
    }
}
