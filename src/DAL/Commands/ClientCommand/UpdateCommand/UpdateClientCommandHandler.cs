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
                client.FirstName = command.Client.FirstName;
                client.LastName = command.Client.LastName;
                client.BirthDate = command.Client.BirthDate;
                client.Points = command.Client.Points;

                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}
