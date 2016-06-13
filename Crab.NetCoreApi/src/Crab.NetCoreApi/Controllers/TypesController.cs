using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class TypesController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public TypesController([FromServices] IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/types/addresses
        [HttpGet("addresses")]
        public async Task<IEnumerable<CodenameItem>> GetAddressTypes()
        {
            var items = await _client.ListAardAdressenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/types/subaddresses
        [HttpGet("subaddresses")]
        public async Task<IEnumerable<CodenameItem>> GetSubaddressTypes()
        {
            var items = await _client.ListAardSubadressenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/types/buildings
        [HttpGet("buildings")]
        public async Task<IEnumerable<CodenameItem>> GetBuildingTypes()
        {
            var items = await _client.ListAardGebouwenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/types/terrainobjects
        [HttpGet("terrainobjects")]
        public async Task<IEnumerable<CodenameItem>> GetTerrainobjectTypes()
        {
            var items = await _client.ListAardTerreinobjectenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }

        // GET api/types/roadobjects
        [HttpGet("roadobjects")]
        public async Task<IEnumerable<CodenameItem>> GetRoadobjectTypes()
        {
            var items = await _client.ListAardWegobjectenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }
    }
}