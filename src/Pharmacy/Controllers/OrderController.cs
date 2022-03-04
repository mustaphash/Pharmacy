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
        [HttpPost("buy")]
        public async Task<IActionResult> BuyMedication(BuyOrAnulateMedicationModel model)
        {
            var pharmacy = model.ToOrder();
            await _createPharmacyCommand.HandleAsync(new PharmacyCommand(pharmacy));

            return NoContent();
        }

        [HttpPost("anullate")]
        public async Task<IActionResult> AnulateOrder(BuyOrAnulateMedicationModel model)
        {
            var pharmacy = model.ToOrder();
            await _createPharmacyCommand.HandleAsync(new PharmacyCommand(pharmacy));

            return NoContent();
        }

        // last endpoint
        [HttpGet("report")]
        public async Task<IActionResult> Report(ReportModel model)
        {
            var pharmacy = model.ToOrder();
            await _createPharmacyCommand.HandleAsync(new PharmacyCommand(pharmacy));

            return NoContent();
        }
    }
}
