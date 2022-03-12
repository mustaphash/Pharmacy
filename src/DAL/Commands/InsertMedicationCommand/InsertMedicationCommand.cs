using Core.Commands;
using Core.Entities;

namespace DAL.Commands.InsertMedicationCommand
{
    public class InsertMedicationCommand : ICommand
    {
        public InsertMedicationCommand(int id, Medicament medicament)
        {
            PharmacyId = id;
            Medicament = medicament;
        }
        public int PharmacyId { get; }
        public Medicament Medicament { get; }
    }
}
