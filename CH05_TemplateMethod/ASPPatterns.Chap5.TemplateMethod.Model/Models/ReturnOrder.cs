using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.TemplateMethod.Model.Models
{
    public class ReturnOrder
    {
        public ReturnAction Action { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal PricePaid { get; set; }
        public decimal PostageCost { get; set; }
        public long ProductId { get; set; }
        public decimal AmountToRefund { get; set; }
    }

}
