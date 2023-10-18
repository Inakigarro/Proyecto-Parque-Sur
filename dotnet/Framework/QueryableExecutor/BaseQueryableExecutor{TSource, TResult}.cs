using Cps.Framework.Specifications;

namespace Cps.Framework;

/// <inheritdoc/>
public abstract class BaseQueryableExecutor<TSource, TResult> : BaseQueryableExecutor<TSource, TResult, TResult>
{
    /// <summary>
    /// Initializes a new instace of the <see cref="BaseQueryableExecutor{TSource, TResult}"/> class.
    /// </summary>
    /// <param name="specification">A <see cref="ISpecification{TSource, TResult}"/> to be applied.</param>
    protected BaseQueryableExecutor(ISpecification<TSource, TResult> specification)
        : base(specification)
    {}
}