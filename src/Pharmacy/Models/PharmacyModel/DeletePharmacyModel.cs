namespace Pharmacy.Models.PharmacyModel
{
    public class DeletePharmacyModel
    {
        public int Id { get; set; }

        public Core.Entities.Pharmacy ToDelete()
        {
            return new Core.Entities.Pharmacy()
            {
                Id = Id
            };
        }
    }
}
