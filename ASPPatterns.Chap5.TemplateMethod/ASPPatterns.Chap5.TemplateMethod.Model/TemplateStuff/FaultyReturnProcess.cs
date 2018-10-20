using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPPatterns.Chap5.TemplateMethod.Model.Models;

namespace ASPPatterns.Chap5.TemplateMethod.Model.TemplateStuff
{
    public class FaultyReturnProcess : ReturnProcessTemplate
    {

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            // Code to send generate order that sends faulty item back to
            // manufacturer...
        }

        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost;
        }
    }
}
