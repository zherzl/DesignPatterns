using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;

namespace Repository
{
    public class AccountRepository : IAccountRepository, IUnitOfWorkRepository
    {
        IUnitOfWork _unitOfWork;

        public AccountRepository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void Add(Account account)
        {
            _unitOfWork.RegisterNew(account, this);
        }

        public void Remove(Account account)
        {
            _unitOfWork.RegisterRemoved(account, this);
        }

        public void Save(Account account)
        {
            _unitOfWork.RegisterAmended(account, this);
        }



        public void PersistCreationOf(IAggregateRoot entity)
        {
            // ADO.NET code to add the entity...
        }

        public void PersistDeletionOf(IAggregateRoot entity)
        {
            // ADO.NET code to delete the entity...
        }

        public void PersistUpdateOf(IAggregateRoot entity)
        {
            // ADO.NET code to update the entity.
        }
    }
}
