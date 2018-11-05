using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class EntityBase<T>
    {
        private T _id;
        private IList<string> _brokenRules = new List<string>();
        private bool idHasBeenSet = false;

        public EntityBase() {  }
        public EntityBase(T id)
        {
            this._id = id;
        }

        public T Id { get { return _id; }
            set
            {
                if (idHasBeenSet)
                {
                    ThrowExceptionIfOverwritingId();
                }

                _id = value;
                idHasBeenSet = true;
            }
        }

        private void ThrowExceptionIfOverwritingId()
        {
            throw new ApplicationException("You cannot change the id of an entity.");
        }

        public bool IsValid()
        {
            ClearCollectionOfBrokenRules();
            CheckForBrokenRules();
            return _brokenRules.Count() == 0;

        }
        
        protected abstract void CheckForBrokenRules();

        private void ClearCollectionOfBrokenRules()
        {
            _brokenRules.Clear();
        }
        public IEnumerable<string> GetBrokenBusinessRules()
        {
            return _brokenRules;
        }
        protected void AddBrokenRule(string brokenRule)
        {
            _brokenRules.Add(brokenRule);
        }

    }
}
