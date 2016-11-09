using System;
using System.Text;
using System.Collections.Generic;
using OrderManagementSystem.UoF;
using System.ComponentModel.DataAnnotations;

namespace OrderManagementSystem.Areas.OMS.Models
{

    public class Fx
    {
        [DataType(DataType.Date)]
        public DateTime? TradeDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? SettlDate { get; set; }
        public string Currency { get; set; }
        public string SettlCurrency { get; set; }
        public double? LastPx { get; set; }
        public double? CurrencyAmt { get; set; }
        public double? SettlCurrencyAmt { get; set; }
        public string Counterparty { get; set; }
        public string OrderID { get; set; }
        public bool? isFXSwap { get; set; }



    }
}
