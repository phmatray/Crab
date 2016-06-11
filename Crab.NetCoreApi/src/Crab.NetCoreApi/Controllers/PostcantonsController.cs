using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WsCrabServiceReference;

namespace Crab.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    public class PostcantonsController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public PostcantonsController([FromServices]IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }
    }
}