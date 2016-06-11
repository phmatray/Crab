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
        private IMapper Mapper { get; set; }

        public RegionsController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
        }

        // GET api/regions
        [HttpGet]
        public async Task<IEnumerable<RegionItem>> Get()
        {
            var client = new WsCrabClient();
            var items = await client.ListGewestenAsync(0);
            var result = Mapper.Map<IEnumerable<RegionItem>>(items);
            return result;
        }

        // GET api/regions/1
        [HttpGet("{id}")]
        public async Task<RegionObject> Get(int id)
        {
            var client = new WsCrabClient();
            var item = await client.GetGewestByGewestIdAndTaalCodeAsync(id, "fr");
            var body = item.Body.GetGewestByGewestIdAndTaalCodeResult;
            var result = Mapper.Map<RegionObject>(body);
            return result;
        }
    }
}