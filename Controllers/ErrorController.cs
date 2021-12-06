using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/error")]
    public class ErrorController : ControllerBase
    {
        [HttpPut]
        public Error Create(Error error)
        {
            Storage.ErrorStorage.Create(error);
            return error;
        }

        [HttpGet]
        public Error Read(int errorId)
        {
            return Storage.ErrorStorage.Read(errorId);;
        }

        [HttpPatch]
        public Error Update(int errorId, Error newerror)
        {
            return Storage.ErrorStorage.Update(errorId, newerror);
        }

        [HttpDelete]
        public bool Delete(int errorId)
        {
            return Storage.ErrorStorage.Delete(errorId);
        }
    }
}