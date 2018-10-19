namespace TemplateMethodPattern_BEH.Model
{
    internal abstract class ReturnProcessTemplate
    {
        // The Template Method pattern is useful when you want to centralize code common to a series of sub
        // classes. To achieve this, you separate the code that varies from the code that is similar; this enables
        // you to avoid duplication and enables better maintenance of your code base.

        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder);
        protected abstract void CalculateRefundFor(ReturnOrder returnOrder);
        public void Process(ReturnOrder returnOrder)
        {
            GenerateReturnTransactionFor(returnOrder);
            CalculateRefundFor(returnOrder);
        }

    }
}