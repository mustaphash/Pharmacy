using Core.Entities;

namespace Pharmacy.Models.PharmacyModel
{
    public class DeletePharmacyModel
    {
        public int Id { get; set; }

        public Client ToDelete()
        {
            return new Client()
            {
                Id = Id
            };
        }
    }
}
