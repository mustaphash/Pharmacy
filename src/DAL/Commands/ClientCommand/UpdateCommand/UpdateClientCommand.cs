using Core.Commands;
using Core.Entities;

namespace DAL.Commands.ClientCommand.UpdateCommand
{
    public class UpdateClientCommand : ICommand
    {
        public UpdateClientCommand(Client client)
        {
            Client = client;
        }
        public Client Client { get; }
    }
}
