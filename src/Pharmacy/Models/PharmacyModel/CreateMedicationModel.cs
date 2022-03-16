using Core.Entities;

namespace Pharmacy.Models.PharmacyModel
{
    public class CreateMedicationModel
    {
        public CreateMedicationModel()
        {
            Name = String.Empty;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int PharmacyId { get; set; }

        public Medicament ToMedicament()
        {
            return new Medicament
            {
                Name = Name,
                Price = Price,
                ExpirationDate = ExpirationDate,
            };
        }
    }
}
