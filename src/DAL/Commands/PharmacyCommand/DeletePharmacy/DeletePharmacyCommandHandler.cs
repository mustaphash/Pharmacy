using Core.Commands;

namespace DAL.Commands.PharmacyCommand.DeletePharmacy
{
    public class DeletePharmacyCommandHandler : ICommandHandler<DeletePharmacyCommand>
    {
        public readonly PharmacyContext _pharmacyContext;
        public DeletePharmacyCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(DeletePharmacyCommand command, CancellationToken cancellationToken = default)
        {
            var pharmacy = _pharmacyContext.Pharmacies.FirstOrDefault(p => p.Id == command.Id);
            if (pharmacy != null)
            {
                _pharmacyContext.Pharmacies.Remove(pharmacy);
                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}
