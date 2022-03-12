using Core.Commands;
using Microsoft.EntityFrameworkCore;

namespace DAL.Commands.InsertMedicationCommand
{
    public class InsertMedicationCommandHandler : ICommandHandler<InsertMedicationCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public InsertMedicationCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(InsertMedicationCommand command, CancellationToken cancellationToken = default)
        {
            var pharmacy = await _pharmacyContext.Pharmacies.FirstOrDefaultAsync(x => x.Id == command.PharmacyId);
            if (pharmacy != null)
            {
                pharmacy.Medicaments.Add(command.Medicament);
                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}

