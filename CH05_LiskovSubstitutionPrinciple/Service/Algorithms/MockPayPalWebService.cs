using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MockPayPalWebService
    {
        public string ObtainToken(string accountName, string password)
        {
            return "xxxxxxxx - xxxxxxxxxxxxxx - xxxxxxxxx";
        }
        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth: 0999";
        }
    }
}
