using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Query
{
    public enum CriteriaOperator
    {
        Equal, LessThanOrEqual, NotApplicable
    }

    public enum QueryOperator
    {
        And,
        Or
    }

    public enum QueryName
    {
        Dynamic = 0,
        RetrieveOrdersUsingAComplexQuery = 1
    }
}
