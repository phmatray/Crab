using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public StatusController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/status/housenumbers
        [HttpGet("housenumbers")]
        public async Task<IEnumerable<CodenameItem>> GetStatusHousenumbers()
        {
            var items = await _client.ListStatusHuisnummersAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/status/streetnames
        [HttpGet("streetnames")]
        public async Task<IEnumerable<CodenameItem>> GetStatusStreetnames()
        {
            var items = await _client.ListStatusStraatnamenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/status/subaddresses
        [HttpGet("subaddresses")]
        public async Task<IEnumerable<CodenameItem>> GetStatusSubaddresses()
        {
            var items = await _client.ListStatusSubadressenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/status/roadsegments
        [HttpGet("roadsegments")]
        public async Task<IEnumerable<CodenameItem>> GetStatusRoadsegments()
        {
            var items = await _client.ListStatusWegsegmentenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/status/buildings
        [HttpGet("buildings")]
        public async Task<IEnumerable<CodenameItem>> GetStatusBuildings()
        {
            var items = await _client.ListStatusGebouwenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }
    }
}