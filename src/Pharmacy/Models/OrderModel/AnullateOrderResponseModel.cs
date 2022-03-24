using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class AnullateOrderResponseModel
    {
        public AnullateOrderResponseModel(AnullatedOrder anullated)
        {
            Id = anullated.Id;
            ClientId = anullated.ClientId;
            MedicamentId = anullated.MedicamentId;
            PharmacyId = anullated.PharmacyId;
            CreateDate = anullated.CreateDate;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PharmacyId { get; set; }
        public int MedicamentId { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
