using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HasReachedRentalThresholdSpecification : ISpecification<CustomerAccount>
    {
        public bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.NumberOfRentalsThisMonth >= 5;
        }
    }
}
