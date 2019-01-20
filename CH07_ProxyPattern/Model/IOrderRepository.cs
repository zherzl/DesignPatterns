using System;
using System.Collections.Generic;

namespace Model
{
    public interface IOrderRepository
    {
        IEnumerable<Order> FindAllBy(Guid customerId);

    }
}