using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factory
{
    public class TicketPurchaseFactory
    {
        public static TicketPurchase CreateTicket(Event Event, int tktQty)
        {
            TicketPurchase ticket = new TicketPurchase();
            ticket.Id = Guid.NewGuid();
            ticket.Event = Event;
            ticket.TicketQuantity = tktQty;
            return ticket;
        }
    }

    public class TicketReservationFactory
    {
        public static TicketReservation CreateReservation(Event Event, int tktQty)
        {
            TicketReservation reservation = new TicketReservation();
            reservation.Id = Guid.NewGuid();
            reservation.Event = Event;
            reservation.ExpiryTime = DateTime.Now.AddMinutes(1);
            reservation.TicketQuantity = tktQty;
            return reservation;
        }
    }
}
