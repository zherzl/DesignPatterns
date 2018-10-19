using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap4.DomainModel.AppService.ViewModel
{
    public class TransactionView
    {
        public string Deposit { get; set; }
        public string Withdrawal { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }
    }
    public class BankAccountView
    {
        public Guid AccountNo { get; set; }
        public string Balance { get; set; }
        public string CustomerRef { get; set; }
        public IList<TransactionView> Transactions { get; set; }
    }
}
