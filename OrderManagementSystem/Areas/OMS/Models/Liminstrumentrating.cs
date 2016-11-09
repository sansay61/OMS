using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Liminstrumentrating : IVersionedEntity
    {
        public virtual int Id { get; set; }
        public virtual int InstrumentId { get; set; }
        public virtual int RatingId { get; set; }
        public virtual int SubjectTypeId { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual Ratings Ratings { get; set; }
        public virtual Subjecttypes Subjecttypes { get; set; }
        public virtual Users User { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual int Version { get; set; }
        public virtual decimal? Inid { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
    }
}
