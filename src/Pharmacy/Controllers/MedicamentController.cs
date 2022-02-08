using Core.Entities;
using Core.Queries;
using DAL.Queries.GetAllMedicaments;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    [Route("medicaments")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly IQueryHandler<GetAllMedicamentsQuery, IList<Medicament>> _getAllMedicamentsQuery;
        public MedicamentController(
            IQueryHandler<GetAllMedicamentsQuery, IList<Medicament>> getAllMedicamentsQuery)
        {
            _getAllMedicamentsQuery = getAllMedicamentsQuery;
        }

        [HttpGet(Name = "GetAllMedicaments")]
        public async Task<IActionResult> GetAllMedicaments()
        {
            IList<Medicament> medicaments = await _getAllMedicamentsQuery.HandleAsync(new GetAllMedicamentsQuery());

            return Ok(medicaments);
        }
    }
}
