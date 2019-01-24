using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Query
{
    public class OrderByClause
    {
        public string PropertyName { get; set; }
        public bool Desc { get; set; }

        public static OrderByClause Create(string propertyName, bool desc)
        {
            return new OrderByClause
            {
                PropertyName = propertyName, Desc = desc
            };
        }
    }
}
