using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class CommunesController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public CommunesController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/communes/1
        [HttpGet("{id}")]
        public async Task<CommuneObject> Get(int id)
        {
            var item = await _client.GetGemeenteByGemeenteIdAsync(id);
            var result = Mapper.Map<CommuneObject>(item);
            return result;
        }
    }
}