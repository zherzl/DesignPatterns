using Model.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    class CustomerAccountHasLateFeesSpecification : CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.LateFees > 0.0m;
        }
    }
}
