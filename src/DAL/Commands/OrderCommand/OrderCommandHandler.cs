using Core.Commands;
using Microsoft.EntityFrameworkCore;

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
            var order = _pharmacyContext.Orders.Include(m => m.Medicament).Include(c => c.Client).Include(p => p.Pharmacy).FirstOrDefaultAsync();
            if (order != null)
            {
                await _pharmacyContext.AddAsync(command.Order);
                 _pharmacyContext.SaveChanges();
            }
        }
    }
}
