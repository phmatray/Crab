using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class RegionsController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public RegionsController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/regions
        [HttpGet]
        public async Task<IEnumerable<RegionItem>> Get()
        {
            var items = await _client.ListGewestenAsync(0);
            var result = Mapper.Map<IEnumerable<RegionItem>>(items);
            return result;
        }

        // GET api/regions/1
        [HttpGet("{id}")]
        public async Task<RegionObject> Get(int id)
        {
            var response = await _client.GetGewestByGewestIdAndTaalCodeAsync(id, "fr");
            var item = response.Body.GetGewestByGewestIdAndTaalCodeResult;
            var result = Mapper.Map<RegionObject>(item);
            return result;
        }

        // GET api/regions/1/communes
        [HttpGet("{id}/communes")]
        public async Task<object> GetCommunes(int id)
        {
            var items = await _client.ListGemeentenByGewestIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<CommuneItem>>(items);
            return result;
        }
    }
}