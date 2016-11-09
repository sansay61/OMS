using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{
    //6
    public class Limdistribution : IVersionedEntity
    {
        public Limdistribution() { }
        public virtual int Id { get; set; }
        public virtual Users User { get; set; }
        public virtual decimal Minpercent { get; set; }
        public virtual decimal Maxpercent { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual int Version { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
        public virtual decimal? Inid { get; set; }
    }
}
