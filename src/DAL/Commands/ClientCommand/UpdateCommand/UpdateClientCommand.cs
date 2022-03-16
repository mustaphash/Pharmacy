using Core.Commands;
using Core.Entities;

namespace DAL.Commands.ClientCommand.UpdateCommand
{
    public class UpdateClientCommand : ICommand
    {
        public UpdateClientCommand(int id,Client client)
        {
            Id = id;
            Client = client;
        }
        public int Id { get; set; }
        public Client Client { get; }
    }
}
