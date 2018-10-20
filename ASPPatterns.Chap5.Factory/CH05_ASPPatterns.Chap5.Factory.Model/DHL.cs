namespace CH05_ASPPatterns.Chap5.Factory.Model
{
    public class DHL : IShippingCourier
    {
        public string GenerateConsignmentLabelFor(Address address)
        {
            return "DHL-XXXX-XXXX-XXXX";
        }
    }
}