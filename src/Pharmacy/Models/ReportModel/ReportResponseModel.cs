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
        }

        public decimal TotalRevenue { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // TODO: Fix for anullated orders
        // public int AnullatedOrdersCount => AnulatedOrders != null ? AnulatedOrders.Count() : 0;

        public int OrdersCount => Orders != null ? Orders.Count() : 0;

        // TODO: Fix for anullated orders
        //public IEnumerable<AnulatedOrder> AnulatedOrders { get; set; }

        public IEnumerable<OrderResponseModel> Orders { get; set; }
    }
}
