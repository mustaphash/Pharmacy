using Core.Entities;
using Core.Queries;
using DAL.Queries.GetAllClients;
using Microsoft.AspNetCore.Mvc;

namespace Pharmacy.Controllers
{
    [Route("clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IQueryHandler<GetAllClientsQuery, IList<Client>> _getAllClientsQuery;
        public ClientController(
            IQueryHandler<GetAllClientsQuery, IList<Client>> getAllClientsQuery)
        {
            _getAllClientsQuery = getAllClientsQuery;
        }

        [HttpGet(Name = "GetAllClients")]
        public async Task<IActionResult> GetAllClients()
        {
            IList<Client> clients = await _getAllClientsQuery.HandleAsync(new GetAllClientsQuery());

            return Ok(clients);
        }
        //CRUD Clients
        [HttpPost]
        public async Task<IActionResult> CreateClient(IList<Client> client)
        {
            IList<Client> clients = await _getAllClientsQuery.CreateClient(client);
            return Created($"GetAllClients/{client}",clients);
        }
    }
}
