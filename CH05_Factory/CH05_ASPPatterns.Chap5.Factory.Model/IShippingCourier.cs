using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_ASPPatterns.Chap5.Factory.Model
{
    public interface IShippingCourier
    {
        string GenerateConsignmentLabelFor(Address address);
 
    }
}
