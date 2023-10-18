namespace Cps.Framework;

/// <summary>
/// Interface for defining a queryable executor.
/// </summary>
/// <typeparam name="TSource">The source type.</typeparam>
/// <typeparam name="TResult">The result type.</typeparam>
public interface IQueryableExecutor<in TSource, TResult>
{
    /// <summary>
    /// Executes a querying operation over a <see cref="IQueryable"/>.
    /// </summary>
    /// <param name="queryable">The <see cref="IQueryable"/> to be operated over.</param>
    /// <param name="cancellationToken">The cancellation token instance.</param>
    /// <returns>A task with the querying operation result.</returns>
    public Task<TResult> ExecuteAsync(IQueryable<TSource> queryable, CancellationToken cancellationToken = default);
}