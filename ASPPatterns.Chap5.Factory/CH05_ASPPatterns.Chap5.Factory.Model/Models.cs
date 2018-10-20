using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_ASPPatterns.Chap5.Factory.Model
{
    public class Address
    {
        public string CountryCode { get; set; }
    }

    public class Order
    {
        public decimal TotalCost { get; set; }
        public decimal WeightInKG { get; set; }
        public string CourierTrackingId { get; set; }
        public Address DispatchAddress { get; set; }
    }

}
