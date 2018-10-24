using System;
using System.Collections.Generic;

namespace TemaPatru.Repository.Interfaces
{
    public interface IGenericRepository<T>
    where T : class
    {
        void Create(T generic);

        void Update(T generic);

        void Delete(T generic);

        List<T> GetAll();

        T GetById(Guid id);

    }
}