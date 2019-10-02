using DesignPatterns.Persistence.RepositoryPattern.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Persistence.RepositoryPattern.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        int Complete();
    }
}
