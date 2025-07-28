using MetricsAnomalyDetector.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MetricsAnomalyDetector.Application.Repositories
{
    public interface ICommandRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        void Add(T item);
        T Remove(T item);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> predicate);
    }

    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
