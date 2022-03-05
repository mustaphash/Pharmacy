using Core.Commands;

namespace DAL.Commands.ClientCommand
{
    public class DeleteClientCommand : ICommand
    {
        public DeleteClientCommand(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}
