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

        // GET api/streetnames/1/housenumbers/withstatus
        [HttpGet("{id}/housenumbers/withstatus")]
        public async Task<IEnumerable<HousenumberWithStatusItem>> GetHousenumbersWithstatus(int id)
        {
            var items = await _client.ListHuisnummersWithStatusByStraatnaamIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<HousenumberWithStatusItem>>(items);
            return result;
        }

        // GET api/streetnames/1/roadobjects
        [HttpGet("{id}/roadobjects")]
        public async Task<IEnumerable<RoadobjectItem>> GetRoadobjects(int id)
        {
            var items = await _client.ListWegobjectenByStraatnaamIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<RoadobjectItem>>(items);
            return result;
        }

        // GET api/streetnames/1/roadsegments
        [HttpGet("{id}/roadsegments")]
        public async Task<IEnumerable<RoadsegmentItem>> GetRoadsegments(int id)
        {
            var items = await _client.ListWegsegmentenByStraatnaamIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<RoadsegmentItem>>(items);
            return result;
        }

        // GET api/streetnames/1/postaladdresses
        [HttpGet("{id}/postaladdresses")]
        public async Task<IEnumerable<PostaladdressItem>> GetPostaladdresses(int id)
        {
            var items = await _client.ListPostadressenByStraatnaamIdAsync(id);
            var result = Mapper.Map<IEnumerable<PostaladdressItem>>(items);
            return result;
        }

        // GET api/streetnames/1/nationalregisterstreets
        [HttpGet("{id}/nationalregisterstreets")]
        public async Task<IEnumerable<NationalregisterstreetItem>> GetNationalregisterstreets(int id)
        {
            var items = await _client.ListRijksregisterStratenByStraatnaamIdAsync(id);
            var result = Mapper.Map<IEnumerable<NationalregisterstreetItem>>(items);
            return result;
        }

        // GET api/streetnames/1/addresstypes
        [HttpGet("{id}/addresstypes")]
        public async Task<IEnumerable<CodenameItem>> GetAddresstypes(int id)
        {
            var items = await _client.ListAardAdressenAsync(id);
            var result = Mapper.Map<IEnumerable<CodenameItem>>(items);
            return result;
        }
    }
}