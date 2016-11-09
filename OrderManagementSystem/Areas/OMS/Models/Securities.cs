using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;
using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Security
    {
        [DataType(DataType.Date)]
        public DateTime? TradeDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? SettlDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? MaturityDate { get; set; }
        public double? Price { get; set; }
        public double? Nominal { get; set; }
        public string SecurityID { get; set; }
        public string SecurityIDSource { get; set; }
        public double? Yield { get; set; }
        public double? Couponrate { get; set; }
        public string Currency { get; set; }
        public double? GrosstradeAmt { get; set; }
        public double? AccruedInterestAmt { get; set; }
        public double? NetMoney { get; set; }
        public string SecurityType { get; set; }
        public string Issuer { get; set; }
        public string Counterparty { get; set; }


    }
}
