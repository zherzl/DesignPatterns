using DataContract;
using EventTickets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
    public class TicketServiceClientProxy : ClientBase<ITicketService>, ITicketService
    {
        public ReserveTicketResponse ReserveTicket(ReserveTicketRequest reserveTicketRequest)
        {
            return base.Channel.ReserveTicket(reserveTicketRequest);
        }
        public PurchaseTicketResponse PurchaseTicket(PurchaseTicketRequest purchaseTicketRequest)
        {
            return base.Channel.PurchaseTicket(purchaseTicketRequest);
        }
    }
}
