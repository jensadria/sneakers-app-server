using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApi.Models
{
    public class Sneaker
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("brand")]
        public string Brand { get; set; }

        [BsonElement("model")]
        public string Model { get; set; }

        [BsonElement("size")]
        public string Size { get; set; }

        [BsonElement("colorway")]
        public string Colorway { get; set; }

        [BsonElement("releaseyear")]
        public string ReleaseYear { get; set; }

    }
}
