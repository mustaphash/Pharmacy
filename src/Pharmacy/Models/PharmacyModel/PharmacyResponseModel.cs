namespace Pharmacy.Models.PharmacyModel
{
    public class PharmacyResponseModel
    {
        public PharmacyResponseModel(Core.Entities.Pharmacy pharmacy)
        {
            Id = pharmacy.Id;
            Name = pharmacy.Name;
            Address = pharmacy.Address;
            PhoneNumber = pharmacy.PhoneNumber;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
    }
}
