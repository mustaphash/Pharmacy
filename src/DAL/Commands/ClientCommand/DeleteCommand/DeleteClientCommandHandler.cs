using Core.Commands;

namespace DAL.Commands.ClientCommand
{
    public class DeleteClientCommandHandler : ICommandHandler<DeleteClientCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public DeleteClientCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(DeleteClientCommand command, CancellationToken cancellationToken = default)
        {
            var client = _pharmacyContext.Clients.FirstOrDefault(c => c.Id == command.Id);
            if (client != null)
            {
                _pharmacyContext.Clients.Remove(client);
                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}
