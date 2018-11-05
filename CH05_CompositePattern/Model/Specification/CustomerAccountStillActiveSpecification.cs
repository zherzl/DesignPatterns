using Model.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Specification
{
    class CustomerAccountStillActiveSpecification : CompositeSpecification<CustomerAccount>
    {
        public override bool IsSatisfiedBy(CustomerAccount candidate)
        {
            // Nema smisla u ovom trenutku, ali ako bismo dodali još jedan uvjet (npr. ima li Email potvrđen, onda se smisao mijenja)
            return candidate.AccountActive;
        }
    }
}
