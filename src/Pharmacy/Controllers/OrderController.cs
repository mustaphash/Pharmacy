using Core.Commands;
using DAL.Commands.OrderCommand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models.OrderModel;

namespace Pharmacy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        //kupuvane na medikament ot specifichna apteka.
        //Otchet za period(StartDate EndDate)
        //Anulirane na poruchka(AnulatedOrders s kolona Status)
        //Otchet za anulirani poruchki za period
        private readonly ICommandHandler<OrderCommand> _createOrderCommand;
        public OrderController(
            ICommandHandler<OrderCommand> createOrderCommand)
        {
            _createOrderCommand = createOrderCommand;
        }

        [HttpPost("buy")]
        public async Task<IActionResult> BuyMedication(BuyOrAnulateMedicationModel model)
        {
            var order = model.ToOrder();
            await _createOrderCommand.HandleAsync(new OrderCommand(order));

            return NoContent();
        }

        [HttpPost("anullate")]
        public async Task<IActionResult> AnulateOrder(BuyOrAnulateMedicationModel model)
        {
            var order = model.ToOrder();
            await _createOrderCommand.HandleAsync(new OrderCommand(order));

            return NoContent();
        }

        // last endpoint
        [HttpGet("report")]
        public async Task<IActionResult> Report(ReportModel model)
        {

            return NoContent();
        }
    }
}
