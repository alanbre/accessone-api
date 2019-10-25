using AccessOne.Domain.Core.Models;
using FluentValidation;
using System.Collections.Generic;

namespace AccessOne.Domain.Interfaces
{
    public interface IService<TEntity> where TEntity : Entity
    {
        TEntity Post<V>(TEntity obj) where V : AbstractValidator<TEntity>;

        TEntity Put<V>(TEntity obj) where V : AbstractValidator<TEntity>;

        void Delete(int id);

        TEntity Get(int id);

        IList<TEntity> Get();
    }
}