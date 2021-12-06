using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/station")]
    public class StationController : ControllerBase
    {
        [HttpPut]
        public Station Create(Station station)
        {
            Storage.StationStorage.Create(station);
            return station;
        }

        [HttpGet]
        public Station Read(int stationId)
        {
            return Storage.StationStorage.Read(stationId);;
        }

        [HttpPatch]
        public Station Update(int stationId, Station newstation)
        {
            return Storage.StationStorage.Update(stationId, newstation);
        }

        [HttpDelete]
        public bool Delete(int stationId)
        {
            return Storage.StationStorage.Delete(stationId);
        }
    }
}