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
    public class ShipWreckController : ControllerBase
    {
        private readonly IMongoCollection<Shipwreck> _shipwreckCollection;

        public ShipWreckController(IMongoClient client)
        {
            var database = client.GetDatabase("sample_geospatial");
            _shipwreckCollection = database.GetCollection<Shipwreck>("shipwrecks");
        }

        [HttpGet]
        public IEnumerable<Shipwreck> Get()
        {
            return _shipwreckCollection.Find(s => s.FeatureType == "Wrecks - Visible").ToList();
        }
    }
}