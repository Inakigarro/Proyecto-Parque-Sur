namespace Cps.Persistence;

public interface IRepository<TId, TEntity> : IReadOnlyRepository<TId, TEntity>
    where TEntity : class
    where TId : notnull
{
    Task CreateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
}