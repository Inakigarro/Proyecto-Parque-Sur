using Cps.Framework.Specifications;

namespace Cps.Framework;

/// <summary>
/// Base class to be inherited from to implement a <see cref="IQueryableExecutor{TSource, TResult}"/>.
/// </summary>
/// <typeparam name="TSource">The source type.</typeparam>
/// <typeparam name="TResult">The result type.</typeparam>
/// <typeparam name="TProjection">The projected type.</typeparam>
public abstract class BaseQueryableExecutor<TSource, TResult, TProjection> : IQueryableExecutor<TSource, TProjection>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseQueryableExecutor{TSource, TResult, TProjection}"/> class.
    /// </summary>
    /// <param name="specification">A <see cref="ISpecification{TSource, TResult}"/> to be applied.</param>
    protected BaseQueryableExecutor(ISpecification<TSource, TResult> specification){
        this.Specification = specification;
    }

    /// <summary>
    /// Gets or sets the <see cref="ISpecification{TSource, TResult}"/> to be applied.
    /// </summary>
    /// <value></value>
    public ISpecification<TSource, TResult> Specification { get; set; }

    /// <summary>
    /// Executes a given operation over a <see cref="IQueryable"/>.
    /// </summary>
    /// <param name="queryable">The <see cref="IQueryable"/> to be executed over.</param>
    /// <param name="cancellationToken">The cancellation token instance.</param>
    /// <returns>A task containing the resulting <typeparamref name="TProjection"/></returns>
    public abstract Task<TProjection> ExecuteAsync(IQueryable<TSource> queryable, CancellationToken cancellationToken = default);
}