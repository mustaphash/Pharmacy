using Core.Commands;

namespace DAL.Commands.OrderCommand
{
    public class OrderCommandHandler : ICommandHandler<OrderCommand>
    {
        private readonly PharmacyContext _pharmacyContext;
        public OrderCommandHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task HandleAsync(OrderCommand command, CancellationToken cancellationToken = default)
        {
            await _pharmacyContext.AddAsync(command.Order);
            await _pharmacyContext.SaveChangesAsync();

        }
    }
}
