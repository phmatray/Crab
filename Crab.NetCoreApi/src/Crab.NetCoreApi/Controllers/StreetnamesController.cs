using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class StreetnamesController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public StreetnamesController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/streetnames/1
        [HttpGet("{id}")]
        public async Task<StreetnameObject> Get(int id)
        {
            var item = await _client.GetStraatnaamByStraatnaamIdAsync(id);
            var result = Mapper.Map<StreetnameObject>(item);
            return result;
        }

        // GET api/streetnames/1/withstatus
        [HttpGet("{id}/withstatus")]
        public async Task<StreetnameWithStatusObject> GetWithStatus(int id)
        {
            var item = await _client.GetStraatnaamWithStatusByStraatnaamIdAsync(id);
            var result = Mapper.Map<StreetnameWithStatusObject>(item);
            return result;
        }

        // GET api/streetnames/1/housenumbers
        [HttpGet("{id}/housenumbers")]
        public async Task<IEnumerable<HousenumberItem>> GetHousenumbers(int id)
        {
            var items = await _client.ListHuisnummersByStraatnaamIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<HousenumberItem>>(items);
            return result;
        }
    }
}