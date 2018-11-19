using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace DataContract
{
    [DataContract]
    public class PurchaseTicketRequest
    {
        [DataMember]
        public string CorrelationId { get; set; }
        [DataMember]
        public string ReservationId { get; set; }
        [DataMember]
        public string EventId { get; set; }
    }

    [DataContract]
    public class ReserveTicketRequest
    {
        [DataMember]
        public string EventId { get; set; }
        [DataMember]
        public int TicketQuantity { get; set; }
    }
}
