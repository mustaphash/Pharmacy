using Core.Entities;

namespace Pharmacy.Models.MedicationModel
{
    public class MedicationResponseModel
    {
        public MedicationResponseModel(Medicament medicament)
        {
            Id = medicament.Id;
            Name = medicament.Name;
            Price = medicament.Price;
            ExpirationDate = medicament.ExpirationDate;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Medicament ToMedicament()
        {
            return new Medicament()
            {
                Id = Id,
                Name = Name,
                Price = Price,
                ExpirationDate = ExpirationDate
            };
        }
    }
}
