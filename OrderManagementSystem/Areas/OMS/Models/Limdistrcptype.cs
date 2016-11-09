using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Limdistrcptype : IEntity
    {
        public virtual int Id { get; set; }
        public virtual int InstrumentId { get; set; }
        public virtual int SubjectTypeId { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual Subjecttypes Subjecttypes { get; set; }
        public virtual Limdistribution Limdistribution { get; set; }
    }
}
