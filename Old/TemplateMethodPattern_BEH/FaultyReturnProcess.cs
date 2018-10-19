using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_BEH.Model
{
    class FaultyReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            
            returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost;

        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            // Code to send generate order that sends faulty item back to
            // manufacturer...
        }
    }
}
