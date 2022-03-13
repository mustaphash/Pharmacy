using Core.Commands;
using Core.Entities;

namespace DAL.Commands.AnullateOrderCommand
{
    public class AnullateOrderCommand : ICommand
    {
        public AnullateOrderCommand(AnullatedOrder order)
        {
            Order = order;
        }

        public AnullatedOrder Order { get; }
    }
}
