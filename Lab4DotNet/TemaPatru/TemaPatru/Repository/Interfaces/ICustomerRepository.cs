using TemaPatru.Entities;

namespace TemaPatru.Repository.Interfaces
{
    public interface ICustomerRepository: IGenericRepository<CustomerEntity>
    {
        CustomerEntity GetCustomerByEmail(string email);
    }
}