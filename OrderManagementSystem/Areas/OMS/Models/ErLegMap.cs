using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using OrderManagementSystem.Areas.OMS.Models; 

namespace OrderManagementSystem.Areas.OMS.Models {
    
    
    public class ErLegMap : ClassMap<ErLeg> {
        
        public ErLegMap() {
			Table("ER_LEGS");
			LazyLoad();
            Id(x => x.Id, "ID").GeneratedBy.Increment();
			Map(x => x.Erid).Column("ERID").Not.Nullable().Length(22);
			Map(x => x.Legsymbol).Column("LEGSYMBOL").Length(50);
			Map(x => x.Legproduct).Column("LEGPRODUCT").Length(22);
			Map(x => x.Legsecuritytype).Column("LEGSECURITYTYPE").Length(50);
			Map(x => x.Legside).Column("LEGSIDE").Length(22);
			Map(x => x.Legcurrency).Column("LEGCURRENCY").Length(3);
			Map(x => x.Legqty).Column("LEGQTY").Length(22);
			Map(x => x.Legrefid).Column("LEGREFID").Length(50);
			Map(x => x.Legsettltype).Column("LEGSETTLTYPE").Length(50);
			Map(x => x.Legsettldate).Column("LEGSETTLDATE").Length(7);
			Map(x => x.Leglastpx).Column("LEGLASTPX").Length(22);
			Map(x => x.Leglastforwardpoints).Column("LEGLASTFORWARDPOINTS").Length(22);
			Map(x => x.Legcalculatedccylastqty).Column("LEGCALCULATEDCCYLASTQTY").Length(22);
			Map(x => x.Legno).Column("LEGNO").Length(22);
        }
    }
}
