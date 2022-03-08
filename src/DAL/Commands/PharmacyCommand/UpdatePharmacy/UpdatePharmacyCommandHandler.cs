using Core.Commands;

namespace DAL.Commands.PharmacyCommand.UpdatePharmacy
{
    public class UpdatePharmacyCommandHandler : ICommandHandler<UpdatePharmacyCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public UpdatePharmacyCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(UpdatePharmacyCommand command, CancellationToken cancellationToken = default)
        {
            if (command != null)
            {
                _pharmacyContext.Update(command.Pharmacy);
                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}
