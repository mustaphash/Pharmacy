using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.GetOrders
{
    public class GetOrdersQueryHandler : IQueryHandler<GetOrdersQuery, IList<Order>>
    {
        private readonly PharmacyContext _pharmacyContext;
        public GetOrdersQueryHandler(PharmacyContext pharmacyContext)
        {
            _pharmacyContext = pharmacyContext;
        }
        public async Task<IList<Order>> HandleAsync(GetOrdersQuery query, CancellationToken cancellationToken = default)
        {
            List<Order> orders = await _pharmacyContext.Orders.ToListAsync(cancellationToken);
            orders = new List<Order>();
            orders.Select(o => o.Client.FirstName);


            return orders;
        }
    }
}
