using MetricsAnomalyDetector.Application.Repositories;
using MetricsAnomalyDetector.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MetricsAnomalyDetector.Persistence.Postgre;

public class CommandRepository<T> : ICommandRepository<T> where T : class, IAggregateRoot
{
    private readonly PostgreDbContext _context;
    private readonly DbSet<T> _dbSet;

    public CommandRepository(PostgreDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        UnitOfWork = unitOfWork;
        this._dbSet = _context.Set<T>();
    }

    public IUnitOfWork UnitOfWork { get; }

    public void Add(T item) => _dbSet.Add(item);

    public Task<T?> GetAsync(Expression<Func<T, bool>> predicate) =>
        GetAggreagteQueryable().FirstOrDefaultAsync(predicate);

    public Task<List<T>> GetListAsync(Expression<Func<T, bool>> predicate) =>
        GetAggreagteQueryable().Where(predicate).ToListAsync();

    public T Remove(T item) => _dbSet.Remove(item).Entity;

    protected virtual IQueryable<T> GetAggreagteQueryable() => _dbSet;
}
