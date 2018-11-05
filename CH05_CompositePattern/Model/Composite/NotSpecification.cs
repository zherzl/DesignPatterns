using Model.Specification;

namespace Model.Composite
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> _innerSpecification;
        public NotSpecification(ISpecification<T> innerSpecification)
        {
            this._innerSpecification = innerSpecification;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return !_innerSpecification.IsSatisfiedBy(candidate);
        }
    }
}