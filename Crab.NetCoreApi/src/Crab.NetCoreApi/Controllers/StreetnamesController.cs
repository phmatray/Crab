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
    }
}