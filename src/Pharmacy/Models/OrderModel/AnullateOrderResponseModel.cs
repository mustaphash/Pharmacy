using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class AnullateOrderResponseModel
    {
        public AnullateOrderResponseModel(AnullatedOrder anullated)
        {
            Id = anullated.Id;
            ClientName = anullated.Client.FirstName + " " + anullated.Client.LastName;
            PharmacyName = anullated.Pharmacy.Name;
            MedicamentName = anullated.Medicament.Name;
            CreateDate = anullated.CreateDate;
        }

        public int Id { get; set; }
        public string ClientName { get; set; }

        // Pharmacy Name
        public string PharmacyName { get; set; }

        // MedicamentName
        public string MedicamentName { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
