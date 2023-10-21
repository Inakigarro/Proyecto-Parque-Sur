namespace Cps.Persistence;

/// <summary>
/// Defines a repository contract for <typeparamref name="TEntity"/> entity
/// with the <typeparamref name="TId"/> identifier type.
/// </summary>
/// <typeparam name="TId">The entity identifier type.</typeparam>
/// <typeparam name="TEntity">The entity type.</typeparam>
public interface IReadOnlyRepository<TId, TEntity>
    where TEntity : class
    where TId : notnull
{
    Task<IEnumerable<TEntity>> AllAsync(CancellationToken cancellationToken = default);

    Task<TEntity> FindById(TId id, CancellationToken cancellationToken = default);

    Task<IEnumerable<TResult>> SearchAsync<TResult>(
        ISpecification<TEntity,TResult> specification,
        CancellationToken cancellationToken = default)
        where TResult : class;
}
