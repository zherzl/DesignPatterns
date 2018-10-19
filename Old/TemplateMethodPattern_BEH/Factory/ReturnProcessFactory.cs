using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_BEH.Model
{
    class ReturnProcessFactory
    {
        public static ReturnProcessTemplate CreateFrom(ReturnAction returnAction)
        {
            switch (returnAction)
            {
                case ReturnAction.FaultyReturn:
                    return new FaultyReturnProcess();
                case ReturnAction.NoQuibblesReturn:
                    return new NoQuibblesReturnProcess();
                default:
                    throw new ApplicationException("No process template");
            }
        }
    }
}
