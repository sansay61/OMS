using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Assets : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual DateTime? Ondate { get; set; }
        public virtual string Accname { get; set; }
        public virtual string Acc { get; set; }
        public virtual decimal? Restnom2 { get; set; }
        public virtual decimal? Restequ2 { get; set; }
        public virtual decimal? Restusd2 { get; set; }

        public override string ToString()
        {
            return Ondate.ToString();
        }
    }
}
