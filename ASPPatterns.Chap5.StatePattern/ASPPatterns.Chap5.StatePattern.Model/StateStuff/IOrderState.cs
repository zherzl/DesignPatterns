using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap5.StatePattern.Model
{
    public interface IOrderState
    {
        OrderStatusEnum Status { get; }

        bool CanShip(Order order);
        void Ship(Order order);
        bool CanCancel(Order order);
        void Cancel(Order order);

    }
}
