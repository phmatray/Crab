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
    public class HousenumbersController : Controller
    {
        private readonly WsCrabClient _client;
        private IMapper Mapper { get; set; }

        public HousenumbersController([FromServices] IMapper mapper)
        {
            Mapper = mapper;
            _client = new WsCrabClient();
        }

        // GET api/housenumbers/1
        [HttpGet("{id}")]
        public async Task<HousenumberObject> Get(int id)
        {
            var item = await _client.GetHuisnummerByHuisnummerIdAsync(id);
            var result = Mapper.Map<HousenumberObject>(item);
            return result;
        }

        // GET api/housenumbers/1/withstatus
        [HttpGet("{id}/withstatus")]
        public async Task<HousenumberWithStatusObject> GetWithStatus(int id)
        {
            var item = await _client.GetHuisnummerWithStatusByHuisnummerIdAsync(id);
            var result = Mapper.Map<HousenumberWithStatusObject>(item);
            return result;
        }

        // GET api/housenumbers/1/postaladdress
        [HttpGet("{id}/postaladdress")]
        public async Task<PostaladdressObject> GetPostaladdress(int id)
        {
            var item = await _client.GetPostadresByHuisnummerIdAsync(id);
            var result = Mapper.Map<PostaladdressObject>(item);
            return result;
        }

        // GET api/housenumbers/1/postalcanton
        [HttpGet("{id}/postalcanton")]
        public async Task<PostalcantonObject> GetPostalcanton(int id)
        {
            var item = await _client.GetPostkantonByHuisnummerIdAsync(id);
            var result = Mapper.Map<PostalcantonObject>(item);
            return result;
        }

        // GET api/housenumbers/1/addresspositions
        [HttpGet("{id}/addresspositions")]
        public async Task<IEnumerable<AddresspositionItem>> GetAddresspositions(int id)
        {
            var items = await _client.ListAdrespositiesByHuisnummerIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<AddresspositionItem>>(items);
            return result;
        }

        // GET api/housenumbers/1/buildings
        [HttpGet("{id}/buildings")]
        public async Task<IEnumerable<BuildingItem>> GetBuildings(int id)
        {
            var items = await _client.ListGebouwenByHuisnummerIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<BuildingItem>>(items);
            return result;
        }

        // GET api/housenumbers/1/parcels
        [HttpGet("{id}/parcels")]
        public async Task<IEnumerable<ParcelItem>> GetParcels(int id)
        {
            var items = await _client.ListPercelenByHuisnummerIdAsync(id);
            var result = Mapper.Map<IEnumerable<ParcelItem>>(items);
            return result;
        }

        // GET api/housenumbers/1/nationalregisteraddresses
        [HttpGet("{id}/nationalregisteraddresses")]
        public async Task<IEnumerable<NationalregisterAddressItem>> GetNationalregisterAddresses(int id)
        {
            var items = await _client.ListRijksregisterAdresByHuisnummerIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<NationalregisterAddressItem>>(items);
            return result;
        }

        // GET api/housenumbers/1/subaddresses
        [HttpGet("{id}/subaddresses")]
        public async Task<IEnumerable<SubaddressItem>> GetSubaddresses(int id)
        {
            var items = await _client.ListSubadressenByHuisnummerIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<SubaddressItem>>(items);
            return result;
        }

        // GET api/housenumbers/1/subaddresses/withstatus
        [HttpGet("{id}/subaddresses/withstatus")]
        public async Task<IEnumerable<SubaddressWithStatusItem>> GetSubaddressesWithstatus(int id)
        {
            var items = await _client.ListSubadressenWithStatusByHuisnummerIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<SubaddressWithStatusItem>>(items);
            return result;
        }

        // GET api/housenumbers/1/terrainobjects
        [HttpGet("{id}/terrainobjects")]
        public async Task<IEnumerable<TerrainobjectItem>> GetTerrainobjects(int id)
        {
            var items = await _client.ListTerreinobjectenByHuisnummerIdAsync(id, 0);
            var result = Mapper.Map<IEnumerable<TerrainobjectItem>>(items);
            return result;
        }
    }
}