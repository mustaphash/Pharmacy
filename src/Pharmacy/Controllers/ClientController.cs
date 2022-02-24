﻿using Core.Commands;
using Core.Entities;
using Core.Queries;
using DAL.Commands.ClientCommand;
using DAL.Commands.ClientCommand.UpdateCommand;
using DAL.Commands.CreateClient;
using DAL.Queries.GetAllClients;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Models;
using Pharmacy.Models.ClientModels;

namespace Pharmacy.Controllers
{
    [Route("clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IQueryHandler<GetAllClientsQuery, IList<Client>> _getAllClientsQuery;
        private readonly ICommandHandler<ClientCommand> _createClientCommand;
        private readonly ICommandHandler<DeleteClientCommand> _deleteClientCommand;
        private readonly ICommandHandler<UpdateClientCommand> _updateClientCommand;

        public ClientController(
            IQueryHandler<GetAllClientsQuery, IList<Client>> getAllClientsQuery,
            ICommandHandler<ClientCommand> createClientCommand,
            ICommandHandler<DeleteClientCommand> deleteClientCommand,
            ICommandHandler<UpdateClientCommand> updateClientCommand)
        {
            _getAllClientsQuery = getAllClientsQuery;
            _createClientCommand = createClientCommand;
            _deleteClientCommand = deleteClientCommand;
            _updateClientCommand = updateClientCommand;
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

        [HttpPut]
        public async Task<IActionResult> UpdateClient(CreateClientModel clientModel)
        {
            var client = clientModel.ToClient();
            await _updateClientCommand.HandleAsync(new UpdateClientCommand(client));

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient(DeleteClientModel clientModel)
        {
            var client = clientModel.ToDelete();
            await _deleteClientCommand.HandleAsync(new DeleteClientCommand(client));

            return NoContent();
        }
    }
}
