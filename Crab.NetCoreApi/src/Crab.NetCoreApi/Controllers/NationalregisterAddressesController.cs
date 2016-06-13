using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class NationalregisterAddressesController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public NationalregisterAddressesController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/nationalregisteraddresses/1/housenumbers/withstatus
        [HttpGet("{id}/housenumbers/withstatus")]
        public async Task<IEnumerable<HousenumberWithStatusItem>> GetHousenumbersWithStatus(int id)
        {
            var items = await _client.ListHuisnummersWithStatusByRijksregisterAdresIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<HousenumberWithStatusItem>>(items);
            return result;
        }

        // GET api/nationalregisteraddresses/1/subadresses/withstatus
        [HttpGet("{id}/subadresses/withstatus")]
        public async Task<IEnumerable<SubaddressWithStatusItem>> GetSubadressesWithStatus(int id)
        {
            var items = await _client.ListSubadressenWithStatusByRijksregisterAdresIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<SubaddressWithStatusItem>>(items);
            return result;
        }
    }
}