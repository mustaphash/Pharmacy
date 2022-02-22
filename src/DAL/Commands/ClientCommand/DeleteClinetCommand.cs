using Core.Entities;

namespace DAL.Commands.ClientCommand
{
    public class DeleteClinetCommand
    {
        public DeleteClinetCommand(Client client)
        {
            Client = client;
        }
        public Client Client { get;}
    }
}
