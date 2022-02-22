using Core.Commands;
using Core.Entities;

namespace DAL.Commands.CreateClient
{
    public class ClientCommand : ICommand
    {
        public ClientCommand(Client client)
        {
            Client = client;
        }
        public Client Client { get;}
    }
}
