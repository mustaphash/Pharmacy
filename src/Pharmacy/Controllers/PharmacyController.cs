using Core.Queries;
using DAL.Queries.GetAllPharmacies;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    [Route("pharmacies")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly IQueryHandler<GetAllPharmaciesQuery, IList<Pharmacy>> _getAllPharmaciesQuery;
        public PharmacyController(
            IQueryHandler<GetAllPharmaciesQuery, IList<Pharmacy>> getAllPharmaciesQuery)
        {
            _getAllPharmaciesQuery = getAllPharmaciesQuery;
        }

        [HttpGet(Name = "GetAllPharmacies")]
        public async Task<IActionResult> GetAllPharmacies()
        {
            IList<Pharmacy> pharmacies = await _getAllPharmaciesQuery.HandleAsync(new GetAllPharmaciesQuery());

            return Ok(pharmacies);
        }
    }
}
