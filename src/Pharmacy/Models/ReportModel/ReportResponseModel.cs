using Core.Entities;
using Pharmacy.Models.OrderModel;

namespace Pharmacy.Models.ReportMode
{
    public class ReportResponseModel
    {
        public ReportResponseModel(Report report)
        {
            TotalRevenue = report.TotalRevenue;
            StartDate = report.StartDate;
            EndDate = report.EndDate;
            Orders = report?.Orders?.Select(o => new OrderResponseModel(o));
            AnullatedOrders = report?.AnullatedOrders?.Select(a => new AnullateOrderResponseModel(a));
        }

        public decimal TotalRevenue { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // TODO: Fix for anullated orders
        public int AnullatedOrdersCount => AnullatedOrders != null ? AnullatedOrders.Count() : 0;

        public int OrdersCount => Orders != null ? Orders.Count() : 0;

        // TODO: Fix for anullated orders
        public IEnumerable<AnullateOrderResponseModel> AnullatedOrders { get; set; }

        public IEnumerable<OrderResponseModel> Orders { get; set; }
    }
}
