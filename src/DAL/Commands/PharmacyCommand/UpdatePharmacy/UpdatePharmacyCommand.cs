using Core.Commands;
using Core.Entities;

namespace DAL.Commands.PharmacyCommand.UpdatePharmacy
{
    public class UpdatePharmacyCommand : ICommand
    {
        public UpdatePharmacyCommand(int id, Pharmacy pharmacy)
        {
            Id = id;
            Pharmacy = pharmacy;
        }
        public int Id { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
