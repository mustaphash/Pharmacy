using Core.Commands;
using Core.Queries;
using DAL.Commands.PharmacyCommand;
using DAL.Commands.PharmacyCommand.DeletePharmacy;
using DAL.Commands.PharmacyCommand.UpdatePharmacy;
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
        private readonly ICommandHandler<CreatePharmacyCommand> _createPharmacyCommand;
        private readonly ICommandHandler<DeletePharmacyCommand> _deletePharmacyCommand;
        private readonly ICommandHandler<UpdatePharmacyCommand> _updatePharmacyCommand;
        public PharmacyController(
            IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> getAllPharmaciesQuery,
            ICommandHandler<CreatePharmacyCommand> createPharmacyCommand,
            ICommandHandler<DeletePharmacyCommand> deletePharmacyCommand,
            ICommandHandler<UpdatePharmacyCommand> updatePharmacyCommand)
        {
            _getAllPharmaciesQuery = getAllPharmaciesQuery;
            _createPharmacyCommand = createPharmacyCommand;
            _deletePharmacyCommand = deletePharmacyCommand;
            _updatePharmacyCommand = updatePharmacyCommand;
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
            await _createPharmacyCommand.HandleAsync(new CreatePharmacyCommand(pharmacy));

            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePharmacy(CreatePharmacyModel pharmacyModel)
        {
            var pharmacy = pharmacyModel.ToPharmacy();
            await _updatePharmacyCommand.HandleAsync(new UpdatePharmacyCommand(pharmacy));

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePharmacy(int id)
        {
            await _deletePharmacyCommand.HandleAsync(new DeletePharmacyCommand(id));

            return NoContent();
        }
    }
}
