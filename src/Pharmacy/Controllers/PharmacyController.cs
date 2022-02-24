using Core.Commands;
using Core.Queries;
using DAL.Commands.PharmacyCommand;
using DAL.Commands.PharmacyCommand.DeletePharmacy;
using DAL.Queries.GetAllPharmacies;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;
using Pharmacy.Models.PharmacyModel;

namespace Pharmacy.Controllers
{
    [Route("pharmacies")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> _getAllPharmaciesQuery;
        private readonly ICommandHandler<PharmacyCommand> _createPharmacyCommand;
        private readonly ICommandHandler<DeletePharmacyCommand> _deletePharmacyCommand;
        public PharmacyController(
            IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> getAllPharmaciesQuery,
            ICommandHandler<PharmacyCommand> createPharmacyCommand,
            ICommandHandler<DeletePharmacyCommand> deletePharmacyCommand)
        {
            _getAllPharmaciesQuery = getAllPharmaciesQuery;
            _createPharmacyCommand = createPharmacyCommand;
            _deletePharmacyCommand = deletePharmacyCommand;
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

        [HttpDelete]
        public async Task<IActionResult> DeletePharmacy(DeletePharmacyModel pharmacyModel)
        {
            var pharmacy = pharmacyModel.ToDelete();
            await _deletePharmacyCommand.HandleAsync(new DeletePharmacyCommand(pharmacy));

            return NoContent();
        }
    }
}
