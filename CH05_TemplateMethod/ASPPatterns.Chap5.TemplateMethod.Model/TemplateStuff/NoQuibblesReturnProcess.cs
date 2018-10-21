using ASPPatterns.Chap5.TemplateMethod.Model.Models;

namespace ASPPatterns.Chap5.TemplateMethod.Model.TemplateStuff
{
    public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            // Code to put items back in stock
        }

        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid;
        }

    }
}