namespace Cps.Persistence;

public interface ISpecification<in TSource, out TResult>
{
    IQueryable<TResult> Apply(IQueryable<TSource> query);
}