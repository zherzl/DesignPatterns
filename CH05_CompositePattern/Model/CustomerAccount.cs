using Model.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalTreshold;
        private ISpecification<CustomerAccount> _isAccountActive;
        private ISpecification<CustomerAccount> _hasAccountLateFees;

        public CustomerAccount()
        {
            this._hasReachedRentalTreshold = new HasReachedRentalTresholdSpecification();
            this._isAccountActive = new CustomerAccountStillActiveSpecification();
            this._hasAccountLateFees = new CustomerAccountHasLateFeesSpecification();
        }

        public int NumberOfThresholdsThisMonth { get; set; }

        public bool CanRent()
        {
            ISpecification<CustomerAccount> canRent = 
                _isAccountActive
                    .And(_hasAccountLateFees.Not())
                    .And(_hasAccountLateFees.Not());

            return canRent.IsSatisfiedBy(this);
        }

        public bool AccountActive { get; set; }
        public decimal LateFees { get; set; }

    }
}
