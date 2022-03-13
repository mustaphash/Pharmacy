using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class BuyOrAnulateMedicationModel
    {
        public int MedicationId { get; set; }

        public int PharmacyId { get; set; }

        public int ClientId { get; set; }

        public Order ToOrder()
        {
            return new Order()
            {
                ClientId = ClientId,
                MedicamentId = MedicationId,
                PharmacyId = PharmacyId,
            };
        }

        public AnullatedOrder ToAnulatedOrder()
        {
            return new AnullatedOrder()
            {
                ClientId = ClientId,
                MedicamentId = MedicationId,
                PharmacyId = PharmacyId,
            };
        }
    }
}
