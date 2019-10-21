using System;
using System.Collections.Generic;
using System.Text;

namespace AccessOne.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
