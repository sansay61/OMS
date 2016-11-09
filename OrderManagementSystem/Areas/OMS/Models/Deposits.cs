using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Deposits : IVersionedEntity
    {
        public virtual int Id { get; set; }
        public virtual Operations Operations { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual Instrumentterms Instrumentterms { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual Users User { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual decimal? Yeild { get; set; }
        public virtual DateTime Regdate { get; set; }
        public virtual DateTime Valdate { get; set; }
        public virtual DateTime Enddate { get; set; }
        public virtual decimal? Usdeq { get; set; }
        public virtual decimal Basis { get; set; }
        public virtual int Version { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
        public virtual decimal? Inid { get; set; }
    }
}
