namespace CH05_ASPPatterns.Chap5.Factory.Model
{
    public class OrderService
    {
        public void Dispatch(Order order)
        {
            IShippingCourier shippingCourier = UKShippingCourierFactory.CreateShippingCourier(order);
            order.CourierTrackingId = shippingCourier.GenerateConsignmentLabelFor(order.DispatchAddress);
        }
    }

}