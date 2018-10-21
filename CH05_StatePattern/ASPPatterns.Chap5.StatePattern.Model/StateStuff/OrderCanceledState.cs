using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StatePattern.Model
{
    public class OrderCanceledState : IOrderState
    {
        public OrderStatusEnum Status { get { return OrderStatusEnum.Canceled; } }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("This order is already cancelled!");
        }

        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("You can’t ship a canceled order!");
        }
    }
}
