namespace Model
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;
        public CustomerAccount()
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
        }
        public decimal NumberOfRentalsThisMonth { get; set; }
        public bool CanRent()
        {
            return !_hasReachedRentalThreshold.IsSatisfiedBy(this);
        }

    }
}