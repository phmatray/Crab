using System.Collections.Generic;
using System.Linq;
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

        // GET api/communes/1/postalcantons
        [HttpGet("{id}/postalcantons")]
        public async Task<IEnumerable<PostalcantonItem>> GetPostalcantons(int id)
        {
            var items = await _client.ListPostkantonsByGemeenteIdAsync(id);
            var result = Mapper.Map<IEnumerable<PostalcantonItem>>(items);
            return result;
        }

        // GET api/communes/1/streetnames
        [HttpGet("{id}/streetnames")]
        public async Task<IEnumerable<StreetnameItem>> GetStreetnames(int id)
        {
            var items = await _client.ListStraatnamenByGemeenteIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<StreetnameItem>>(items);
            return result;
        }

        // GET api/communes/1/streetnameswithstatus
        [HttpGet("{id}/streetnameswithstatus")]
        public async Task<IEnumerable<StreetnameWithStatusItem>> GetStreetnamesWithStatus(int id)
        {
            var items = await _client.ListStraatnamenWithStatusByGemeenteIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<StreetnameWithStatusItem>>(items);
            return result;
        }
    }
}