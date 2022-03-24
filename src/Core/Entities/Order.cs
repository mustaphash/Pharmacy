namespace Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PharmacyId { get; set; }
        public int MedicamentId { get; set; }
        public DateTime CreateDate { get; set; }

        public Pharmacy Pharmacy { get; set; }
        public Medicament Medicament { get; set; }
        public Client Client { get; set; }
    }
}
