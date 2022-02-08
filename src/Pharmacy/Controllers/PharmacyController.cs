using Core.Queries;
using DAL.Queries.GetAllPharmacies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly IQueryHandler<GetAllPharmaciesQuery, IList<Pharmacy>>
    }
}
