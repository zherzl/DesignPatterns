using Model.Specification;

namespace Model.Composite
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        private CompositeSpecification<T> _leftSpecification;
        private ISpecification<T> _rightSpecification;

        public AndSpecification(CompositeSpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            this._leftSpecification = leftSpecification;
            this._rightSpecification = rightSpecification;
        }

        public override bool IsSatisfiedBy(T candidate)
        {
            return _leftSpecification.IsSatisfiedBy(candidate) && _rightSpecification.IsSatisfiedBy(candidate);
        }
    }
}