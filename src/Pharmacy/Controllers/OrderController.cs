using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
