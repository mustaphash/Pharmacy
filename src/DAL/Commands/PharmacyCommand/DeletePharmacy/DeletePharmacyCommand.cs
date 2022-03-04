using Core.Commands;

namespace DAL.Commands.PharmacyCommand.DeletePharmacy
{
    public class DeletePharmacyCommand : ICommand
    {
        public DeletePharmacyCommand(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}
