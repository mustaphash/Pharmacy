using Core.Commands;
using Core.Entities;

namespace DAL.Commands.OrderCommand
{
    public class OrderCommand : ICommand
    {
        public OrderCommand(Order order)
        {
            Order = order;
        }
        public Order Order { get; set; }
    }
}
