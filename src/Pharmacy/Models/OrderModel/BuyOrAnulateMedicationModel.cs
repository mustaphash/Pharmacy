using Core.Entities;

namespace Pharmacy.Models.OrderModel
{
    public class BuyOrAnulateMedicationModel
    {
        public BuyOrAnulateMedicationModel()
        {
            MedicationName = String.Empty;
            PharmacyName = String.Empty;
            ClientName = String.Empty;
        }
        public string MedicationName { get; set; }

        public string PharmacyName { get; set; }

        public string ClientName { get; set; }

        public Order ToOrder()
        {
            return new Order()
            {
                ClientName = ClientName,
                MedicamentName = MedicationName,
                PharmacyName = PharmacyName,
            };
        }

        public AnullatedOrder ToAnulatedOrder()
        {
            return new AnullatedOrder()
            {
                ClientName = ClientName,
                MedicamentName = MedicationName,
                PharmacyName = PharmacyName,
            };
        }
    }
}
