using ASPPatterns.Chap5.TemplateMethod.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.TemplateMethod.Model.TemplateStuff
{
    public abstract class ReturnProcessTemplate
    {
        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder);
        protected abstract void CalculateRefundFor(ReturnOrder returnOrder);
        public void Process(ReturnOrder returnOrder)
        {
            GenerateReturnTransactionFor(returnOrder);
            CalculateRefundFor(returnOrder);
        }

    }

}
