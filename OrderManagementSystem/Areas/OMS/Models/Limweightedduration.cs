using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{
    //7
    public class Limweightedduration : IVersionedEntity
    {
        public virtual int Id { get; set; }
        public virtual int UserId { get; set; }
        public virtual int InstrumentId { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual Users User { get; set; }
        public virtual decimal Mindays { get; set; }
        public virtual decimal Maxdays { get; set; }
        public virtual decimal Aimdays { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual int Version { get; set; }
        public virtual decimal? Inid { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
    }
}
