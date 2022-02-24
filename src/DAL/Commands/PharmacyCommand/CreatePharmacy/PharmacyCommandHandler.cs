using Core.Commands;

namespace DAL.Commands.PharmacyCommand
{
    public class PharmacyCommandHandler : ICommandHandler<PharmacyCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public PharmacyCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(PharmacyCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.AddAsync(command.Pharmacy);
            await _pharmacyContext.SaveChangesAsync();
        }
    }
}
