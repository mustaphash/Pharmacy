using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class AnullateOrderResponseModel
    {
        public AnullateOrderResponseModel(AnullatedOrder anullated)
        {
            Id = anullated.Id;
            ClientName = anullated.Client.FirstName;
            MedicamentName = anullated.Medicament.Name;
            PharmacyName = anullated.Pharmacy.Name;
            CreateDate = anullated.CreateDate;
        }

        public int Id { get; set; }
        public string ClientName { get; set; }
        public string MedicamentName { get; set; }
        public string PharmacyName { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
