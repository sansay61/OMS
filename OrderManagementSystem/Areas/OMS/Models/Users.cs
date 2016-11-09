using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models
{
    
    public class Users: IVersionedEntity {
        public Users() { }
        public virtual int  Id { get; set; }
        public virtual Depts Depts { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime? Passexpirationdate { get; set; }
        public virtual decimal Triesleft { get; set; }
        public virtual short Isactive { get; set; }
        public virtual int Version { get; set; }
        public virtual short? Iscurrent { get; set; }
        public virtual DateTime Chtimestamp { get; set; }
        public virtual decimal? Chuserid { get; set; }
        public virtual Users User { get; set; }
        public virtual decimal? Inid { get; set; }
    }
}
