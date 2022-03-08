using Core.Commands;
using Core.Entities;

namespace DAL.Commands.PharmacyCommand
{
    public class CreatePharmacyCommand : ICommand
    {
        public CreatePharmacyCommand(Pharmacy pharmacy)
        {
            Pharmacy = pharmacy;
        }
        public Pharmacy Pharmacy { get; }
    }
}
