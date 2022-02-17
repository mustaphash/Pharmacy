using Core.Entities;

namespace Core.Queries
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken = default);
        Task<TResult> CreateClient(TResult result);
    }
}
