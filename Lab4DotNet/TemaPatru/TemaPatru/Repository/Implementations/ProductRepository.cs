using System;
using System.Collections.Generic;
using System.Linq;
using TemaPatru.Entities;
using TemaPatru.Repository.Interfaces;

namespace TemaPatru.Repository.Implementations
{
    public class ProductRepository: IProductRepository
    {
        private readonly ProductAndCustomerManagementContext _context;

        public ProductRepository(ProductAndCustomerManagementContext product)
        {
            _context = product;
        }

        public void Create(ProductEntity productEntity)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == productEntity.Id);

            if(product != null) return;

            _context.Products.Add(productEntity);
            _context.SaveChanges();
        }

        public void Update(ProductEntity productEntity)
        {
            var existingProduct = _context.Products.First(t => t.Id == productEntity.Id);

            existingProduct.Name = productEntity.Name;
            existingProduct.Description = productEntity.Description;
            existingProduct.EndDate = productEntity.EndDate;
            existingProduct.StartDate = productEntity.StartDate;
            existingProduct.Vat = productEntity.Vat;
            existingProduct.Price = productEntity.Price;

            _context.SaveChanges();
        }

        public void Delete(ProductEntity productEntity)
        {
            var existingProduct = _context.Products.FirstOrDefault(t => t.Id == productEntity.Id);

            _context.Products.Remove(existingProduct ?? throw new InvalidOperationException());

            _context.SaveChanges();
        }

        public List<ProductEntity> GetAll()
        {
            return _context.Products.ToList();
        }

        public ProductEntity GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(t => t.Id == id);
        }

        public List<ProductEntity> GetProductsByPrice(double price)
        {
            return _context.Products.ToList().FindAll(t => t.Price.CompareTo(price) == 0);
        }
    }
}