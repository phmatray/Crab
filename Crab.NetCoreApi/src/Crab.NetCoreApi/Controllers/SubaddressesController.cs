using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class SubaddressesController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public SubaddressesController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/subaddresses/1
        [HttpGet("{id}")]
        public async Task<SubaddressObject> Get(int id)
        {
            var item = await _client.GetSubadresBySubadresIdAsync(id);
            var result = Mapper.Map<SubaddressObject>(item);
            return result;
        }

        // GET api/subaddresses/1/withstatus
        [HttpGet("{id}/withstatus")]
        public async Task<SubaddressWithStatusObject> GetWithstatus(int id)
        {
            var item = await _client.GetSubadresWithStatusBySubadresIdAsync(id);
            var result = Mapper.Map<SubaddressWithStatusObject>(item);
            return result;
        }

        // GET api/subaddresses/1/withstatus
        [HttpGet("{id}/postaladdress")]
        public async Task<PostaladdressObject> GetPostaladdress(int id)
        {
            var item = await _client.GetPostadresBySubadresIdAsync(id);
            var result = Mapper.Map<PostaladdressObject>(item);
            return result;
        }

        // GET api/subaddresses/1/addresspositions
        [HttpGet("{id}/addresspositions")]
        public async Task<IEnumerable<AddresspositionItem>> GetAddresspositions(int id)
        {
            var items = await _client.ListAdrespositiesBySubadresIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<AddresspositionItem>>(items);
            return result;
        }

        // GET api/subaddresses/1/nationalregisteraddresses
        [HttpGet("{id}/nationalregisteraddresses")]
        public async Task<IEnumerable<NationalregisterAddressItem>> GetNationalregisterAddress(int id)
        {
            var items = await _client.ListRijksregisterAdresBySubadresIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<NationalregisterAddressItem>>(items);
            return result;
        }
    }
}