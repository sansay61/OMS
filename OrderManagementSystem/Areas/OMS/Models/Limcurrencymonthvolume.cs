using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Limcurrencymonthvolume : IVersionedEntity
    {
        public virtual int Id { get; set; }
        public virtual int CurrencyId { get; set; }
        public virtual int ChUserId { get; set; }
        public virtual Currencies Currencies { get; set; }
        public virtual Users User { get; set; }
        public virtual decimal Volume { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual int Version { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
        public virtual decimal? Inid { get; set; }
    }
}
