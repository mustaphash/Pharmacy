using Core.Commands;

namespace DAL.Commands.CreateClient
{
    public class ClientCommandHandler : ICommandHandler<ClientCommand>
    {

        private readonly PharmacyContext _pharmacyContext;

        public ClientCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }

        public async Task HandleAsync(ClientCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.AddAsync(command.Client);
            await _pharmacyContext.SaveChangesAsync();
        }
    }
}
