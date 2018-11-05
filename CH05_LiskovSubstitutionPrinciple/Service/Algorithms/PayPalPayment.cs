using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PayPalPayment : PaymentServiceBase
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public PayPalPayment(string accountName, string password)
        {
            this.AccountName = accountName;
            this.Password = password;
        }

        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            RefundResponse refundResponse = new RefundResponse();

            MockPayPalWebService payPalWebService = new MockPayPalWebService();
            string token = payPalWebService.ObtainToken(AccountName, Password);
            string response = payPalWebService.MakeRefund(amount, transactionId, token);

            refundResponse.Message = response;
            if (response.Contains("A_Success"))
                refundResponse.Success = true;
            else
                refundResponse.Success = false;

            return refundResponse;
        }
    }
}
