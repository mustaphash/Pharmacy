namespace Pharmacy.Models.PharmacyModel
{
    public class UpdatePharmacyModel
    {
        public UpdatePharmacyModel()
        {
            Name = String.Empty;
            Address = String.Empty;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public Core.Entities.Pharmacy UpdatePharmacy()
        {
            return new Core.Entities.Pharmacy()
            {
                Name = Name,
                Address = Address,
                PhoneNumber = PhoneNumber,
            };
        }
    }
}
