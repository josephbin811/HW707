using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW707.Models.ViewModels
{
    public class CashFlowViewModel
    {
        public string FlowType { get; set; }
        public DateTime FlowDate { get; set; }
        public decimal FlowAmount { get; set; }
    }
}