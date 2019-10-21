using AccessOne.Domain.Models;
using System.Collections.Generic;

namespace AccessOne.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> Select();
    }
}

