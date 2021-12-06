using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/refueller")]
    public class RefuellerController : ControllerBase
    {
        [HttpPut]
        public Refueller Create(Refueller refueller)
        {
            Storage.RefuellerStorage.Create(refueller);
            return refueller;
        }

        [HttpGet]
        public Refueller Read(int refuellerId)
        {
            return Storage.RefuellerStorage.Read(refuellerId);;
        }

        [HttpPatch]
        public Refueller Update(int refuellerId, Refueller newrefueller)
        {
            return Storage.RefuellerStorage.Update(refuellerId, newrefueller);
        }

        [HttpDelete]
        public bool Delete(int refuellerId)
        {
            return Storage.RefuellerStorage.Delete(refuellerId);
        }
    }
}