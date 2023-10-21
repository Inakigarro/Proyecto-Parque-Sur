using Cps.Persistence;
using Cps.Sports.Application.Domain;

namespace Cps.Sports.Persistence;

public class SportsRepository : IRepository<Guid, Sport>
{
    public SportsRepository()
    {}

    public Task<IEnumerable<Sport>> AllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(Sport entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Sport entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Sport> FindById(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TResult>> SearchAsync<TResult>(ISpecification<Sport, TResult> specification, CancellationToken cancellationToken = default) where TResult : class
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Sport entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}