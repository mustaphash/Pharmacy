using Core.Commands;

namespace DAL.Commands.PharmacyCommand
{
    public class CreatePharmacyCommandHandler : ICommandHandler<CreatePharmacyCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public CreatePharmacyCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(CreatePharmacyCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.AddAsync(command.Pharmacy);
            await _pharmacyContext.SaveChangesAsync();
        }
    }
}
