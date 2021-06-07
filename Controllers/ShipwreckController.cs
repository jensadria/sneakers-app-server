using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using SneakersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipwreckController : ControllerBase
    {
        private readonly IMongoCollection<Shipwreck> _shipwreckCollection;

        public ShipwreckController(IMongoClient client)
        {
            var database = client.GetDatabase("sample_geospatial");
            _shipwreckCollection = database.GetCollection<Models.Shipwreck>("shipwrecks");
        }

        [HttpGet]
        public IEnumerable<Shipwreck> Get()
        {
            return _shipwreckCollection.Find(s => s.FeatureType == "Wrecks - Visible").ToList();
        }
    }
}