using ASPPatterns.Chap5.TemplateMethod.Model.Factory;
using ASPPatterns.Chap5.TemplateMethod.Model.Models;
using ASPPatterns.Chap5.TemplateMethod.Model.TemplateStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.TemplateMethod.Model.Services
{
    public class ReturnOrderService
    {
        public void Process(ReturnOrder returnOrder)
        {
            ReturnProcessTemplate returnProcess = ReturnProcessFactory.CreateFrom(returnOrder.Action);
            returnProcess.Process(returnOrder);
            // Code to refund the money back to the customer...
        }

    }
}
