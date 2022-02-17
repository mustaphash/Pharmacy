using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllPharmacies
{
    public class GetAllPharmaciesQueryHandler : IQueryHandler<GetAllPharmaciesQuery, IList<Pharmacy>>
    {
        private readonly PharmacyContext _pharmacyContext;
        public GetAllPharmaciesQueryHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }

        public Task<IList<Client>> CreateClient(IList<Pharmacy> result)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Pharmacy>> HandleAsync(GetAllPharmaciesQuery query, CancellationToken cancellationToken = default)
        {
            List<Pharmacy> pharmacies = await _pharmacyContext.Pharmacies.ToListAsync(cancellationToken);

            return pharmacies;
        }
    }
}
