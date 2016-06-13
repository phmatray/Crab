using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class AddresspositionsController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public AddresspositionsController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/addresspositions/1
        [HttpGet("{id}")]
        public async Task<IEnumerable<AddresspositionItem>> Get(int id)
        {
            var item = await _client.GetAdrespositieByAdrespositieIdAsync(id);
            var result = Mapper.Map<IEnumerable<AddresspositionItem>>(item);
            return result;
        }
    }
}