namespace Core.Entities
{
    public class AnulatedOrder
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int MedicamentId { get; set; }
        public int PharmacyId { get; set; }
        public string Status { get; set; }

        public Client Client { get; set; }
        public Medicament Medicament { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
