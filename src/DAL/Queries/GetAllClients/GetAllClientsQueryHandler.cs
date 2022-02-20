using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllClients
{
    public class GetAllClientsQueryHandler : IQueryHandler<GetAllClientsQuery, IList<Client>>
    {
        private readonly PharmacyContext _pharmacyContext;
        public GetAllClientsQueryHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }


        public async Task<IList<Client>> HandleAsync(GetAllClientsQuery query, CancellationToken cancellationToken = default)
        {
            List<Client> clients = await _pharmacyContext.Clients.ToListAsync(cancellationToken);
            return clients;
        }
    
    }
}
