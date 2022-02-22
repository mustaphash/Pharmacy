using Core.Commands;
using Core.Queries;
using DAL.Commands.PharmacyCommand;
using DAL.Queries.GetAllPharmacies;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    [Route("pharmacies")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> _getAllPharmaciesQuery;
        private readonly ICommandHandler<PharmacyCommand> _createPharmacyCommand;
        public PharmacyController(
            IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> getAllPharmaciesQuery,
            ICommandHandler<PharmacyCommand> createPharmacyCommand)
        {
            _getAllPharmaciesQuery = getAllPharmaciesQuery;
            _createPharmacyCommand = createPharmacyCommand;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPharmacies()
        {
            IList<Core.Entities.Pharmacy> pharmacies = await _getAllPharmaciesQuery.HandleAsync(new GetAllPharmaciesQuery());

            return Ok(pharmacies);
        }
        //CRUD Pharmacies 
        //Insert Medications
        [HttpPost]
        public async Task<IActionResult> CreatePharmacy(CreatePharmacyModel pharmacyModel)
        {
            var pharmacy = pharmacyModel.ToPharmacy();
            await _createPharmacyCommand.HandleAsync(new PharmacyCommand(pharmacy));

            return NoContent();
        }
    }
}
