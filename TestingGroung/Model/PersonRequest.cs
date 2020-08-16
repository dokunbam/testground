using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingGroung.Model
{
    public class PersonRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Address Addresses { get; set; }
        public Products[] Products { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string FlatNumber { get; set; }
        public string Street { get; set; }
    }

    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
