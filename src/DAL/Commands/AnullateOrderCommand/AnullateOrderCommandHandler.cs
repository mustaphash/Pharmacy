using Core.Commands;

namespace DAL.Commands.AnullateOrderCommand
{
    public class AnullateOrderCommandHandler : ICommandHandler<AnullateOrderCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public AnullateOrderCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(AnullateOrderCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.AnullatedOrders.AddAsync(command.Order);
            await _pharmacyContext.SaveChangesAsync();
        }
    }
}
