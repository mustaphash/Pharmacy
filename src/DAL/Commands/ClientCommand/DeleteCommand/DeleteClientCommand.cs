using Core.Commands;
using Core.Entities;

namespace DAL.Commands.ClientCommand
{
    public class DeleteClientCommand : ICommand
    {
        public DeleteClientCommand(Client client)
        {
            Client = client;
        }
        public Client Client { get; }
    }
}
