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
        // GET api/communes/1/streetnames?query=%guillemins%
        [HttpGet("{id}/streetnames")]
        public async Task<IEnumerable<StreetnameItem>> GetStreetnames(int id, string query = null)
        {
            if (query == null)
            {
                var items = await _client.ListStraatnamenByGemeenteIdAsync(id, 0);
                var result = Mapper.Map<IEnumerable<StreetnameItem>>(items);
                return result;
            }
            else
            {
                var response = await _client.FindStraatnamenAsync(query, id, 0);
                var items = response.Body.FindStraatnamenResult;
                var result = Mapper.Map<IEnumerable<StreetnameItem>>(items);
                return result;
            }
        }

        // GET api/communes/1/streetnames/withstatus
        // GET api/communes/1/streetnames/withstatus?query=%guillemins%
        [HttpGet("{id}/streetnames/withstatus")]
        public async Task<IEnumerable<StreetnameWithStatusItem>> GetStreetnamesWithStatus(int id, string query = null)
        {
            if (query == null)
            {
                var items = await _client.ListStraatnamenWithStatusByGemeenteIdAsync(id, 0);
                var result = Mapper.Map<IEnumerable<StreetnameWithStatusItem>>(items);
                return result;
            }
            else
            {
                var response = await _client.FindStraatnamenWithStatusAsync(query, id, 0);
                var items = response.Body.FindStraatnamenWithStatusResult;
                var result = Mapper.Map<IEnumerable<StreetnameWithStatusItem>>(items);
                return result;
            }
        }
    }
}