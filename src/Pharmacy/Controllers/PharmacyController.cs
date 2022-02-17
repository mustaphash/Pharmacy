using Core.Queries;
using DAL.Queries.GetAllPharmacies;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    [Route("pharmacies")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> _getAllPharmaciesQuery;
        public PharmacyController(
            IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> getAllPharmaciesQuery)
        {
            _getAllPharmaciesQuery = getAllPharmaciesQuery;
        }

        [HttpGet(Name = "GetAllPharmacies")]
        public async Task<IActionResult> GetAllPharmacies()
        {
            IList<Core.Entities.Pharmacy> pharmacies = await _getAllPharmaciesQuery.HandleAsync(new GetAllPharmaciesQuery());

            return Ok(pharmacies);
        }
        //CRUD Pharmacies 
        //Insert Medications
    }
}
