using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class OrderResponseModel
    {
        public OrderResponseModel(Order order)
        {
            Id = order.Id;
            ClientId = order.ClientId;
            PharmacyId = order.PharmacyId;
            MedicamentId = order.MedicamentId;
            CreateDate = order.CreateDate;
        }

        public int Id { get; set; }

        // ClientName
        public int ClientId { get; set; }

        // Pharmacy Name
        public int PharmacyId { get; set; }

        // MedicamentName
        public int MedicamentId { get; set; }
        public string MedicamentName { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
