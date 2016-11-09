using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models;

namespace OrderManagementSystem.Areas.OMS.Models
{
    
    
    public class UsersMap : ClassMap<Users> {
        
        public UsersMap() {
			Table("USERS");
			Id(x => x.Id).GeneratedBy.Assigned().Column("ID");
			References(x => x.Depts).Column("DEPTID");
			Map(x => x.Login).Column("LOGIN").Not.Nullable().Unique().Length(25);
			Map(x => x.Password).Column("PASSWORD").Not.Nullable().Length(256);
            Map(x => x.Name).Column("NAME").Length(50);
            Map(x => x.Email).Column("EMAIL").Length(50);
			Map(x => x.Passexpirationdate).Column("PASSEXPIRATIONDATE").Length(7);
			Map(x => x.Triesleft).Column("TRIESLEFT").Not.Nullable().Length(22);
			Map(x => x.Isactive).Column("ISACTIVE").Not.Nullable().Length(22);
			Map(x => x.Version).Column("VERSION").Length(22);
			Map(x => x.Iscurrent).Column("ISCURRENT").Length(22);
			Map(x => x.Chtimestamp).Column("CHTIMESTAMP").Length(11);
			Map(x => x.Chuserid).Column("CHUSERID").Length(22);
			Map(x => x.Inid).Column("INID").Length(22);
        }
    }
}
