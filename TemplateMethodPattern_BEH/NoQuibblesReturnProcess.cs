using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_BEH.Model
{
    class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            // Code to put items back in stock
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid;
        }
    }
}
