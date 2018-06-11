using DomainModel.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Service.Messages
{
    public class BankAccountCreateRequest
    {
        public string CustomerName { get; set; }
    }

    public class BankAccountCreateResponse : ResponseBase
    {
        public Guid BankAccountId { get; set; }
    }

    public class DepositRequest
    {
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }
    }

    public class FindAllBankAccountResponse : ResponseBase
    {
        public IList<BankAccountView> BankAccountView { get; set; }
    }

    public class FindBankAccountResponse : ResponseBase
    {
        public BankAccountView BankAccount { get; set; }
    }

    public class TransferRequest
    {
        public Guid AccountIdTo { get; set; }
        public Guid AccountIdFrom { get; set; }
        public decimal Amount { get; set; }
    }

    public class TransferResponse : ResponseBase
    {
    }

    public class WithdrawalRequest
    {
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }
    }

}
