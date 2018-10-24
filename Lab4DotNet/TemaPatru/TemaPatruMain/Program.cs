using System;
using System.Collections.Generic;
using TemaPatru;
using TemaPatru.Entities;
using TemaPatru.Repository.Implementations;

namespace TemaPatruMain
{
    class Program
    {
        static void Main()
        {
            var product = new ProductAndCustomerManagementContext();

            var productRepository = new ProductRepository(product);
            var customerRepository = new CustomerRepository(product);

            //product build
            var listOfProductEntities = CreateProductEntities();

            productRepository.Create(listOfProductEntities[0]);
            productRepository.Create(listOfProductEntities[2]);
            productRepository.Update(listOfProductEntities[1]);
            productRepository.GetAll();
            productRepository.GetById(new Guid("CB63A665-9D7C-4A62-AE09-135ABBBC63A0"));
            productRepository.Delete(listOfProductEntities[2]);
            productRepository.GetProductsByPrice(20.2);


            //customer build
            var listOfCustomerEntities = CreateCustomerEntities();

            customerRepository.Create(listOfCustomerEntities[0]);
            customerRepository.Create(listOfCustomerEntities[2]);
            customerRepository.Update(listOfCustomerEntities[1]);
            customerRepository.GetAll();
            customerRepository.GetById(new Guid("36B4733F-F230-4DE8-8403-2B38208D0270"));
            customerRepository.Delete(listOfCustomerEntities[2]);
            customerRepository.GetCustomerByEmail("cosmin@yahoo.com");
        }

        private static List<CustomerEntity> CreateCustomerEntities()
        { 
             var listOfCustomerEntities = new List<CustomerEntity>();

            var cosmin = new CustomerEntity
            {
                Id = new Guid("36B4733F-F230-4DE8-8403-2B38208D0270"),
                Name = "Cosmin",
                Email = "cosmin@gmail.com",
                Address = "Strada Maicuta, nr. 99, scara b",
                PhoneNumber = "0747999999"
            };

            var vlad = new CustomerEntity
            {
                Id = new Guid("36B4733F-F230-4DE8-8403-2B38208D0270"),
                Name = "Vlad",
                Email = "vlad@yahoo.com",
                Address = "Strada Garii, nr. 79, scara c",
                PhoneNumber = "0747777777"
            };

            var razvan = new CustomerEntity
            {
                Id = new Guid("BC8DBA84-A403-497C-80E8-8440F5CD37CF"),
                Name = "Razvan",
                Email = "razvan@gmail.com",
                Address = "Strada Florilor, nr. 89, scara a",
                PhoneNumber = "0747888888"
            };
            
            listOfCustomerEntities.Add(cosmin);
            listOfCustomerEntities.Add(vlad);
            listOfCustomerEntities.Add(razvan);

            return listOfCustomerEntities;
        }

        private static List<ProductEntity> CreateProductEntities()
        {
            var listOfProductEntities = new List<ProductEntity>();

            var banana = new ProductEntity
            {
                Id = new Guid("CB63A665-9D7C-4A62-AE09-135ABBBC63A0"),
                Name = "Banana",
                Description = "Is yellow",
                StartDate = DateTime.Today,
                Price = 20.2,
                Vat = 12
            };

            var tomato = new ProductEntity
            {
                Id = new Guid("CB63A665-9D7C-4A62-AE09-135ABBBC63A0"),
                Name = "Tomato",
                Description = "Is red",
                StartDate = DateTime.Today,
                Price = 19.5,
                Vat = 5
            };

            var cucumber = new ProductEntity
            {
                Id = new Guid("635AACE7-710E-4751-90CD-536EDC1E999B"),
                Name = "Cucumber",
                Description = "Is green",
                StartDate = DateTime.Today,
                Price = 10.5,
                Vat = 25
            };

            listOfProductEntities.Add(banana);
            listOfProductEntities.Add(tomato);
            listOfProductEntities.Add(cucumber);

            return listOfProductEntities;
        }
    }
}
