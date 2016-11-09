using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Subj2ratings : IEntity
    {
        public virtual int Id { get; set; }

        public virtual int SubjectId { get; set; }
        public virtual Subjects Subjects { get; set; }

        public virtual int RatingId { get; set; }
        public virtual Ratings Ratings { get; set; }
    }
}
