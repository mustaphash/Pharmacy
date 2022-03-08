using Core.Commands;

namespace DAL.Commands.CreateClient
{
    public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand>
    {

        private readonly PharmacyContext _pharmacyContext;

        public CreateClientCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }

        public async Task HandleAsync(CreateClientCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.AddAsync(command.Client);
            await _pharmacyContext.SaveChangesAsync();
        }
    }
}
