using Core.Commands;
using Core.Entities;

namespace DAL.Commands.PharmacyCommand
{
    public class PharmacyCommand : ICommand
    {
        public PharmacyCommand(Pharmacy pharmacy)
        {
            Pharmacy = pharmacy;
        }
        public Pharmacy Pharmacy { get; set; }
    }
}
