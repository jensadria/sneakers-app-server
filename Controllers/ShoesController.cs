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
    public class ShoesController : ControllerBase
    {
        private readonly IMongoCollection<Shoe> _shoeCollection;

        public ShoesController(IMongoClient client)
        {
            var database = client.GetDatabase("sneakers");
            _shoeCollection = database.GetCollection<Shoe>("shoes");
        }

        [HttpGet]
        public IEnumerable<Shoe> Get()
        {
            return _shoeCollection.Find(shoe => true).ToList();
        }

        [HttpPost]
        public Shoe Post(Shoe shoe)
        {
            _shoeCollection.InsertOne(shoe);
            return shoe;
        }


        [HttpDelete]
        public void Delete(ObjectId id)
        {
            _shoeCollection.DeleteOne(shoe => shoe.Id == id);
        }
    }
}