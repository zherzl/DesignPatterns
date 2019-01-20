using Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IOrderRepository
    {
        IEnumerable<Order> FindBy(Query query);

    }
}
