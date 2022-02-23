using Core.Commands;
using Core.Entities;
using Core.Queries;
using DAL.Commands.ClientCommand;
using DAL.Commands.CreateClient;
using DAL.Queries.GetAllClients;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    [Route("clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IQueryHandler<GetAllClientsQuery, IList<Client>> _getAllClientsQuery;
        private readonly ICommandHandler<ClientCommand> _createClientCommand;
        private readonly ICommandHandler<DeleteClientCommand> _deleteClientCommand;

        public ClientController(
            IQueryHandler<GetAllClientsQuery, IList<Client>> getAllClientsQuery,
            ICommandHandler<ClientCommand> createClientCommand,
            ICommandHandler<DeleteClientCommand> deleteClientCommand)
        {
            _getAllClientsQuery = getAllClientsQuery;
            _createClientCommand = createClientCommand;
            _deleteClientCommand = deleteClientCommand;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClients()
        {
            IList<Client> clients = await _getAllClientsQuery.HandleAsync(new GetAllClientsQuery());

            return Ok(clients);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientModel clientModel)
        {
            var client = clientModel.ToClient();
            await _createClientCommand.HandleAsync(new ClientCommand(client));

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient(CreateClientModel clientModel)
        {
            var client = clientModel.ToClient();
            await _deleteClientCommand.HandleAsync(new DeleteClientCommand(client));

            return NoContent();
        }
    }
}
