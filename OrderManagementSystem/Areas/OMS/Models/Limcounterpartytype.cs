using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{
    //1 лимит
    public class Limcounterpartytype : IVersionedEntity
    {
        public virtual int Id { get; set; }

        public virtual int UserId { get; set; }
        public virtual int SubjecttypeId { get; set; }
        public virtual Subjecttypes Subjecttypes { get; set; }
        public virtual Users User { get; set; }
        public virtual decimal Maxpercent { get; set; }
        public virtual DateTime Startdate { get; set; }
        public virtual DateTime? Enddate { get; set; }
        public virtual int Version { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
        public virtual decimal? Inid { get; set; }
    }
}
