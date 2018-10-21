namespace CH05_ASPPatterns.Chap5.DecoratorPattern.Model
{
    public class BasePrice : IPrice
    {
        private decimal _cost;
        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
    }
}