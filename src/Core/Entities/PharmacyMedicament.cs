namespace Core.Entities
{
    public class PharmacyMedicament
    {
        public int Id { get; set; }
        public int PharmacyId { get; set; }
        public int MedicamentId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public Medicament Medicament { get; set; }
    }
}
