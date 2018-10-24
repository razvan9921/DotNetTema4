using System;
using System.Collections.Generic;
using System.Linq;
using TemaPatru.Entities;
using TemaPatru.Repository.Interfaces;

namespace TemaPatru.Repository.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ProductAndCustomerManagementContext _context;

        public CustomerRepository(ProductAndCustomerManagementContext product)
        {
            _context = product;
        }

        public void Create(CustomerEntity customerEntity)
        {
            var customer = _context.Customers.FirstOrDefault(t => t.Id == customerEntity.Id);

            if (customer != null) return;

            _context.Customers.Add(customerEntity);
            _context.SaveChanges();
        }

        public void Update(CustomerEntity customerEntity)
        {
            var existingCustomer = _context.Customers.First(t => t.Id == customerEntity.Id);

            existingCustomer.Name = customerEntity.Name;
            existingCustomer.Address = customerEntity.Address;
            existingCustomer.PhoneNumber = customerEntity.PhoneNumber;
            existingCustomer.Email = customerEntity.Email;

            _context.SaveChanges();
        }

        public void Delete(CustomerEntity customerEntity)
        { 
            var existingCustomer = _context.Customers.FirstOrDefault(t=>t.Id == customerEntity.Id);

            _context.Customers.Remove(existingCustomer ?? throw new InvalidOperationException());

            _context.SaveChanges();
        }

        public List<CustomerEntity> GetAll()
        {
            return _context.Customers.ToList();
        }

        public CustomerEntity GetById(Guid id)
        {
            return _context.Customers.FirstOrDefault(t => t.Id == id);
        }

        public CustomerEntity GetCustomerByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(t => t.Email == email);
        }
    }
}