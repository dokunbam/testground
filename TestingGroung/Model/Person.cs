using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingGroung.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReceivedAt { get; set; }
        public PersonAddress Addresses { get; set; }
        public ICollection<PersonProducts> Products { get; set; }
    }

    public class PersonAddress
    {
        public int Id { get; set; }
        public string FlatNumber { get; set; }
        public string Street { get; set; }
    }

    public class PersonProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }


}
