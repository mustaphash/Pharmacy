using Core.Commands;

namespace DAL.Commands.ClientCommand
{
    public class DeleteClientCommandHandler : ICommandHandler<DeleteClinetCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public DeleteClientCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(DeleteClinetCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.Remove(command.Client);

        }
    }
}
