using Model.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    class HasReachedRentalTresholdSpecification : CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.NumberOfThresholdsThisMonth >= 5;
        }
    }
}
