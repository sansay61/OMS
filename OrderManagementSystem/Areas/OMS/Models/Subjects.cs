using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;
using NHibernate.Type;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Subjects : IVersionedEntity
    {
        public Subjects() { }
        public virtual int Id { get; set; }
        public virtual Statuses Statuses
        {
            get;
            set;
        }
        public virtual int StatusId { get; set; }
        public virtual Subjecttypes Subjecttypes { get; set; }
        public virtual int SubjectTypeId { get; set; }
        public virtual Users User { get; set; }
        public virtual int UserId { get; set; }
        public virtual DateTime Opendate { get; set; }
        public virtual DateTime? Closedate { get; set; }
        public virtual string Shortname { get; set; }
        public virtual string Subjectname { get; set; }
        public virtual string Internationalname { get; set; }
        public virtual int Version { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
        public virtual decimal? Inid { get; set; }

        public override string ToString()
        {
            return Subjectname;
        }
    }
}
