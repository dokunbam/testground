using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TestingGroung.Data;
using TestingGroung.Model;

namespace TestingGroung.Entity
{
    public class EntityPersistenceClass
    {
        private readonly TestingGroundDbContext context;
        Person person;
        public EntityPersistenceClass(TestingGroundDbContext _context)
        {
            context = _context;
        }


        private PersonAddress AddressToPersonAddress(Address address)
        {
            var personAdress = new PersonAddress
            {
                FlatNumber = address.FlatNumber,
                Street = address.Street,
            };
            return personAdress;
        }


        private PersonProducts[] ConvertProductsToPersonProducts(Products[] products )
        {
            List<PersonProducts> myPersonProducts = new List<PersonProducts>();
            PersonProducts myPersonProduct;

            foreach (var product in products)
            {
                myPersonProduct = ConvertToPersonProduct(product);
                myPersonProducts.Add(myPersonProduct);
            }
            return myPersonProducts.ToArray();
        }

        private PersonProducts ConvertToPersonProduct(Products product)
        {
            PersonProducts personProduct = new PersonProducts
            {
                Price = product.Price,
                Name = product.Name
            };
            return personProduct;
        }



        internal Person CreatePerson(PersonRequest personRequest)
        {

            var addresses = AddressToPersonAddress(personRequest.Addresses);
            var products = ConvertProductsToPersonProducts(personRequest.Products);

            person = new Person
            {
                Name = personRequest.Name,
                ReceivedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.FFF"),
                Addresses = addresses,
                Products = products
            };
            context.Persons.Add(person);
            context.SaveChanges();

            return person;
        }
    }
}
