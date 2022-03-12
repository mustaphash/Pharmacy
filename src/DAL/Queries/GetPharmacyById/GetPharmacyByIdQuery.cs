using Core.Entities;
using Core.Queries;

namespace DAL.Queries.GetPharmacyById
{
    public class GetPharmacyByIdQuery : IQuery<Pharmacy>
    {
        public GetPharmacyByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}
