using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);;
        }

        [HttpPatch]
        public Client Update(int clientId, Client newClient)
        {
            return Storage.ClientStorage.Update(clientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int clientId)
        {
            return Storage.ClientStorage.Delete(clientId);
        }
    }
}