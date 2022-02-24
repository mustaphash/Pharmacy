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
            _pharmacyContext.Remove(command.Pharmacy);
            await _pharmacyContext.SaveChangesAsync();
        }
    }
}
