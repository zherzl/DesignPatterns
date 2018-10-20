using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StatePattern.Model.StateStuff
{
    public class OrderNewState : IOrderState
    {
        public OrderStatusEnum Status => OrderStatusEnum.New;

        public bool CanCancel(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {
            order.Change(new OrderCanceledState());
        }

        public bool CanShip(Order order)
        {
            return true;
        }

        public void Ship(Order order)
        {
            order.Change(new OrderShippedState());
        }
    }
}
