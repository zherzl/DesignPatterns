using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using DataContract;

namespace EventTickets.Contracts
{
        [ServiceContract(Namespace = "EventTickets.TicketService")]
        public interface ITicketService
        {
            [OperationContract()]
            ReserveTicketResponse ReserveTicket(ReserveTicketRequest reserveTicketRequest);
            [OperationContract()]
            PurchaseTicketResponse PurchaseTicket(PurchaseTicketRequest PurchaseTicketRequest);
    }
}
