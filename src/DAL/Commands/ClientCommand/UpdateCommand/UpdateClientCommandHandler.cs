using Core.Commands;

namespace DAL.Commands.ClientCommand.UpdateCommand
{
    public class UpdateClientCommandHandler : ICommandHandler<UpdateClientCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public UpdateClientCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(UpdateClientCommand command, CancellationToken cancellationToken = default)
        {
            var client = _pharmacyContext.Clients.FirstOrDefault(c => c.Id == command.Id);
            if (client != null)
            {
                _pharmacyContext.Clients.Update(command.Client);
                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}
