using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;


namespace OrderManagementSystem.Areas.OMS.Models {
    
    public class ErLeg:IEntity {
        public virtual int Id { get; set; }
        public virtual double Erid { get; set; }
        public virtual string Legsymbol { get; set; }
        public virtual short? Legproduct { get; set; }
        public virtual string Legsecuritytype { get; set; }
        public virtual short? Legside { get; set; }
        public virtual string Legcurrency { get; set; }
        public virtual double? Legqty { get; set; }
        public virtual string Legrefid { get; set; }
        public virtual string Legsettltype { get; set; }
        public virtual DateTime? Legsettldate { get; set; }
        public virtual double? Leglastpx { get; set; }
        public virtual double? Leglastforwardpoints { get; set; }
        public virtual double? Legcalculatedccylastqty { get; set; }
        public virtual double? Legno { get; set; }
    }
}
