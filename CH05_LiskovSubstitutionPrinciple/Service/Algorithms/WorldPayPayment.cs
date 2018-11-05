using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class WorldPayPayment : PaymentServiceBase
    {
        public string AccountId { get; set; }
        public string AccountPassword { get; set; }
        public string ProductId { get; set; }

        public WorldPayPayment(string accountId, string accountPassword, string productId)
        {
            this.AccountId = accountId;
            this.AccountPassword = accountPassword;
            this.ProductId = productId;
        }

        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            RefundResponse refundResponse = new RefundResponse();

            MockWorldPayWebService worldPayWebService = new MockWorldPayWebService();
            string response = worldPayWebService.MakeRefund(amount, transactionId, AccountId, AccountPassword, ProductId);
            return refundResponse;

        }
    }
}
