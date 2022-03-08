using Core.Commands;
using Core.Entities;

namespace DAL.Commands.CreateClient
{
    public class CreateClientCommand : ICommand
    {
        public CreateClientCommand(Client client)
        {
            Client = client;
        }
        public Client Client { get; }
    }
}
