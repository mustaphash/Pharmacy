using Core.Commands;
using Core.Entities;
using Core.Queries;
using DAL.Commands.AnullateOrderCommand;
using DAL.Commands.OrderCommand;
using DAL.Queries.Report;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models.OrderModel;
using Pharmacy.Models.ReportMode;

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
        private readonly ICommandHandler<AnullateOrderCommand> _anullateOrderCommand;
        private readonly IQueryHandler<GetReportQuery, Report> _getReport;


        public OrderController(
            ICommandHandler<OrderCommand> createOrderCommand,
            ICommandHandler<AnullateOrderCommand> anullateOrderCommand,
            IQueryHandler<GetReportQuery, Report> getReport)
        {
            _createOrderCommand = createOrderCommand;
            _anullateOrderCommand = anullateOrderCommand;
            _getReport = getReport;
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
            var order = model.ToAnulatedOrder();
            await _anullateOrderCommand.HandleAsync(new AnullateOrderCommand(order));

            return NoContent();
        }

        // last endpoint
        [HttpGet("report")]
        public async Task<IActionResult> Report([FromRoute] ReportModel model)
        {
            Report report = await _getReport.HandleAsync(new GetReportQuery(model.StartDate, model.EndDate));
            var reportResponse = new ReportResponseModel(report);

            return Ok(reportResponse);
        }
    }
}
