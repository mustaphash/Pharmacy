using Core.Commands;

namespace DAL.Commands.PharmacyCommand.DeletePharmacy
{
    public class DeletePharmacyCommandHandler : ICommandHandler<DeletePharmacyCommand>
    {
        public Task HandleAsync(DeletePharmacyCommand command, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
