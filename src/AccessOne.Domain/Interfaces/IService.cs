using AccessOne.Domain.Models;
using FluentValidation;
using System.Collections.Generic;

namespace AccessOne.Domain.Interfaces
{
    public interface IService<T> where T : Entity
    {
        T Post<V>(T obj) where V : AbstractValidator<T>;

        T Put<V>(T obj) where V : AbstractValidator<T>;

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}