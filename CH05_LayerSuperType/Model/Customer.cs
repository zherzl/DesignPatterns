using System;

namespace Model
{
    public class Customer : EntityBase<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected override void CheckForBrokenRules()
        {
            if (String.IsNullOrEmpty(FirstName))
                base.AddBrokenRule("You must supply a first name.");
            if (String.IsNullOrEmpty(LastName))
                base.AddBrokenRule("You must supply a last name.");
        }


        public Customer(long Id) : base(Id)
        {

        }


    }
}