using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetPharmacyById
{
    public class GetPharmacyByIdQueryHandler : IQueryHandler<GetPharmacyByIdQuery, Pharmacy>
    {
        private readonly PharmacyContext _pharmacyContext;
        public GetPharmacyByIdQueryHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task<Pharmacy> HandleAsync(GetPharmacyByIdQuery query, CancellationToken cancellationToken = default)
        {   
            var pharmacy = await _pharmacyContext.Pharmacies.FirstOrDefaultAsync(x=>x.Id==query.Id, cancellationToken);
            return pharmacy;
        }
    }
}
