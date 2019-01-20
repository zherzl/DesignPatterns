using System;

namespace ServiceProxy
{
    public class TicketReservationPresentation
    {
        public string EventId { get; set; }
        public string ReservationId { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool TicketWasSuccessfullyReserved { get; set; }
    }
}