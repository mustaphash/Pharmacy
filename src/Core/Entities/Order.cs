namespace Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PharmacyMedicamentId { get; set; }

        public Client Client { get; set; }
        public PharmacyMedicament PharmacyMedicament { get; set; }
    }
}
