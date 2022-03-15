namespace Core.Entities
{
    public class AnullatedOrder
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string MedicamentName { get; set; }
        public string PharmacyName { get; set; }
        public DateTime CreateDate { get; set; }

        public Client Client { get; set; }
        public Medicament Medicament { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
