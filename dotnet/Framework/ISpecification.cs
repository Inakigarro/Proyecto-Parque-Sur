namespace Cps.Framework.Specifications;

/// <summary>
/// Base class for implementing a new type of Specification.
/// </summary>
/// <typeparam name="TSource">The specification source.</typeparam>
/// <typeparam name="TResult">The result after applying the specification.</typeparam>
public interface ISpecification<in TSource, out TResult>
{
    /// <summary>
    /// Applies this specification to a <see cref="IQueryable"/>.
    /// </summary>
    /// <param name="query">The query to modify.</param>
    /// <returns>The resulting query.</returns>
    IQueryable<TResult> Apply(IQueryable<TSource> query);
}