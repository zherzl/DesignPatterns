﻿using System;

namespace Model
{
    public class TicketPurchase
    {
        public Guid Id { get; set; }
        public Event Event { get; set; }
        public int TicketQuantity { get; set; }

    }
}