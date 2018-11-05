using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PaymentServiceFactory
    {
        public static PaymentServiceBase GetPaymentServiceFrom(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.PayPal:
                    return new PayPalPayment("Scott123-PP", "ABCXY-PP");
                case PaymentType.WorldPay:
                    return new WorldPayPayment("Scott123-WP", "ABCXY-WP", "1");
                default:
                    throw new ApplicationException(
                       "No Payment Service available for " +paymentType.ToString()) ;
            }
        }
    }

}
