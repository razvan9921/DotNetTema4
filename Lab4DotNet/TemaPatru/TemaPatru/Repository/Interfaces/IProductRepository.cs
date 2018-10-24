using System.Collections.Generic;
using TemaPatru.Entities;

namespace TemaPatru.Repository.Interfaces
{
    public interface IProductRepository: IGenericRepository<ProductEntity>
    {
        List<ProductEntity> GetProductsByPrice(double price);
    }
}