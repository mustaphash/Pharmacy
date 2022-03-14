using Core.Commands;
using Core.Queries;
using DAL.Commands.InsertMedicationCommand;
using DAL.Commands.PharmacyCommand;
using DAL.Commands.PharmacyCommand.DeletePharmacy;
using DAL.Commands.PharmacyCommand.UpdatePharmacy;
using DAL.Queries.GetAllPharmacies;
using DAL.Queries.GetPharmacyById;
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
        private readonly IQueryHandler<GetPharmacyByIdQuery, Core.Entities.Pharmacy> _getPharmacyByIdQuery;
        private readonly ICommandHandler<CreatePharmacyCommand> _createPharmacyCommand;
        private readonly ICommandHandler<DeletePharmacyCommand> _deletePharmacyCommand;
        private readonly ICommandHandler<UpdatePharmacyCommand> _updatePharmacyCommand;
        private readonly ICommandHandler<InsertMedicationCommand> _insertMedicationCommand;
        public PharmacyController(
            IQueryHandler<GetAllPharmaciesQuery, IList<Core.Entities.Pharmacy>> getAllPharmaciesQuery,
            IQueryHandler<GetPharmacyByIdQuery, Core.Entities.Pharmacy> getPharmacyByIdQuery,
            ICommandHandler<CreatePharmacyCommand> createPharmacyCommand,
            ICommandHandler<DeletePharmacyCommand> deletePharmacyCommand,
            ICommandHandler<UpdatePharmacyCommand> updatePharmacyCommand,
            ICommandHandler<InsertMedicationCommand> insertMedicationCommand)
        {
            _getAllPharmaciesQuery = getAllPharmaciesQuery;
            _getPharmacyByIdQuery = getPharmacyByIdQuery;
            _createPharmacyCommand = createPharmacyCommand;
            _deletePharmacyCommand = deletePharmacyCommand;
            _updatePharmacyCommand = updatePharmacyCommand;
            _insertMedicationCommand = insertMedicationCommand;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPharmacies()
        {
            IList<Core.Entities.Pharmacy> pharmacies = await _getAllPharmaciesQuery.HandleAsync(new GetAllPharmaciesQuery());
            //TODO: Create ResponseModel
            var pharmacyResponse = pharmacies.Select(p => new PharmacyResponseModel(p));
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

        [HttpPost]
        public async Task<IActionResult> InsertMedication(CreateMedicationModel model)
        {
            var medicament = model.ToMedicament();
            await _insertMedicationCommand.HandleAsync(new InsertMedicationCommand(model.PharmacyId, medicament));

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
