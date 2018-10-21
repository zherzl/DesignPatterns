using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StatePattern.Model.StateStuff
{
    public class OrderShippedState : IOrderState
    {
        public OrderStatusEnum Status => OrderStatusEnum.Shipped;

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Ne može jer je poslano");
        }

        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("Već je poslano");
        }
    }
}
