namespace Core.Entities
{
    public class Report
    {
        public decimal TotalRevenue { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int AnullatedOrdersCount => AnullatedOrders != null ? AnullatedOrders.Count() : 0;

        public int OrdersCount => Orders != null ? Orders.Count() : 0;

        public IEnumerable<AnullatedOrder> AnullatedOrders { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
