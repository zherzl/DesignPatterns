using System;

namespace Model
{
    public class Person : EntityBase
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

    }
}