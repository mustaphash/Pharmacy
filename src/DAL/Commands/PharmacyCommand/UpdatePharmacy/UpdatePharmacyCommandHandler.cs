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
            var pharmacy = _pharmacyContext.Pharmacies.FirstOrDefault(p => p.Id == command.Id);
            if (command != null)
            {
                pharmacy.Name = command.Pharmacy.Name;
                pharmacy.Address = command.Pharmacy.Address;
                pharmacy.PhoneNumber = command.Pharmacy.PhoneNumber;

                await _pharmacyContext.SaveChangesAsync();
            }
        }
    }
}
