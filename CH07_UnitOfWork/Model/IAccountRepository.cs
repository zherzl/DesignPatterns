using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IAccountRepository
    {
        void Save(Account account);
        void Add(Account account);
        void Remove(Account account);
    }
}
