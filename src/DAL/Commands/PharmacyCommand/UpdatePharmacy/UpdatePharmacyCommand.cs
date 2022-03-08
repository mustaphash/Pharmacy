using Core.Commands;
using Core.Entities;

namespace DAL.Commands.PharmacyCommand.UpdatePharmacy
{
    public class UpdatePharmacyCommand : ICommand
    {
        public UpdatePharmacyCommand(Pharmacy pharmacy)
        {
            Pharmacy = pharmacy;
        }
        public Pharmacy Pharmacy { get; set; }
    }
}
