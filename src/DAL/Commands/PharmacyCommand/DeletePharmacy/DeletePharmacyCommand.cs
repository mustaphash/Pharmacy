using Core.Commands;
using Core.Entities;

namespace DAL.Commands.PharmacyCommand.DeletePharmacy
{
    public class DeletePharmacyCommand : ICommand
    {
        public DeletePharmacyCommand(Pharmacy pharmacy)
        {
            Pharmacy = pharmacy;
        }
        public Pharmacy Pharmacy { get; }
    }
}
