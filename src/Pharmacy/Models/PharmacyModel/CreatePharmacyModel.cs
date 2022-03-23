namespace Pharmacy.Models
{
    public class CreatePharmacyModel
    {
        public CreatePharmacyModel()
        {
            Name = String.Empty;
            Address = String.Empty;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }


        public Core.Entities.Pharmacy ToPharmacy()
        {
            return new Core.Entities.Pharmacy()
            {
                Name = this.Name,
                Address = this.Address,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
