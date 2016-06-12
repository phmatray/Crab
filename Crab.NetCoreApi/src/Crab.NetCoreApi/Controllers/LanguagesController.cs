using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Crab.NetCoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class LanguagesController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public LanguagesController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/languages
        [HttpGet]
        public async Task<IEnumerable<CodenameItem>> Get()
        {
            var items = await _client.ListTalenAsync(0);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }
    }
}