using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class OrderResponseModel
    {
        public OrderResponseModel(Order order)
        {
            Id = order.Id;
            ClientName = order.Client.FirstName;
            PharmacyName = order.Pharmacy.Name;
            MedicamentName = order.Medicament.Name;
            CreateDate = order.CreateDate;
        }

        public int Id { get; set; }

        // ClientName
        public string ClientName { get; set; }

        // Pharmacy Name
        public string PharmacyName { get; set; }

        // MedicamentName
        public string MedicamentName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
