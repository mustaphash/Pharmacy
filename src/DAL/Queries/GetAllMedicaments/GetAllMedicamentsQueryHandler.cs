using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetAllMedicaments
{
    public class GetAllMedicamentsQueryHandler : IQueryHandler<GetAllMedicamentsQuery, IList<Medicament>>
    {
        private readonly PharmacyContext _pharmacyContext;
        public GetAllMedicamentsQueryHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }

        public Task<IList<Client>> CreateClient(IList<Medicament> result)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Medicament>> HandleAsync(GetAllMedicamentsQuery query, CancellationToken cancellationToken = default)
        {
            List<Medicament> medicaments = await _pharmacyContext.Medicaments.ToListAsync(cancellationToken);

            return medicaments;
        }
    }
}
