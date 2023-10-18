using System.Collections.Generic;

namespace Cps.Framework;

/// <summary>
/// Defines a repository contract for <typeparamref name="TEntity"/> entity
/// with <typeparamref name="TId"/> identifier type.
/// </summary>
/// <typeparam name="TId">The entity identifier type.</typeparam>
/// <typeparam name="TEntity">The entity type.</typeparam>
public interface IReadOnlyRepository<TId, TEntity>
    where TEntity : class
    where TId : notnull
{
    /// <summary>
    /// Gets all the <typeparamref name="TEntity"/> entities asynchronously.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token instance.</param>
    /// <returns>The task containing all the <typeparamref name="TEntity"/> entities.</returns>
    Task<IEnumerable<TEntity>> AllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the entity by its id asynchronously.
    /// </summary>
    /// <param name="correlationId">The entity Correlation Id.</param>
    /// <param name="cancellationToken">The cancellation token instance.</param>
    /// <returns>The typed task as a result of the find <typeparamref name="TEntity"/> operation.</returns>
    Task<TEntity?> FindByIdAsync(TId correlationId, CancellationToken cancellationToken = default);
}
