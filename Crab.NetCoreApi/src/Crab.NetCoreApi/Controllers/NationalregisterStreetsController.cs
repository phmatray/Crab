using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class NationalregisterStreetsController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public NationalregisterStreetsController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/nationalregisterstreets/1,1
        [HttpGet("{streetCode},{subcantonCode}")]
        public async Task<NationalregisterstreetObject> Get(int streetCode, int subcantonCode)
        {
            var item = await _client.GetRijksregisterStraatByRijksregisterStraatCodeAsync(streetCode, subcantonCode);
            var result = Mapper.Map<NationalregisterstreetObject>(item);
            return result;
        }

        // GET api/nationalregisterstreets/1,1/streetname
        [HttpGet("{streetCode},{subcantonCode}/streetname")]
        public async Task<StreetnameObject> GetStreetname(int streetCode, int subcantonCode)
        {
            var item = await _client.GetStraatnaamByRijksregisterStraatCodeAsync(streetCode, subcantonCode);
            var result = Mapper.Map<StreetnameObject>(item);
            return result;
        }

        // GET api/nationalregisterstreets/1,1/streetname/withstatus
        [HttpGet("{streetCode},{subcantonCode}/streetname/withstatus")]
        public async Task<StreetnameWithStatusObject> GetStreetnameWithstatus(int streetCode, int subcantonCode)
        {
            var item = await _client.GetStraatnaamWithStatusByRijksregisterStraatCodeAsync(streetCode, subcantonCode);
            var result = Mapper.Map<StreetnameWithStatusObject>(item);
            return result;
        }
    }
}