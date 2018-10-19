using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_BEH.Model
{
    public class ReturnOrderService
    {
        public void Process(ReturnOrder returnOrder)
        {
            ReturnProcessTemplate rpt = ReturnProcessFactory.CreateFrom(returnOrder.Action);

            rpt.Process(returnOrder);

            // Code to refund the money back to the customer...
        }
    }
}
