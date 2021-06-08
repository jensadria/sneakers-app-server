using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApi.Models
{
    public class Shoe
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("brand")]
        public string Brand { get; set; }

        [BsonElement("model")]
        public string Model { get; set; }

        [BsonElement("size")]
        public int Size { get; set; }

        [BsonElement("colorway")]
        public string Colorway { get; set; }

        [BsonElement("release_year")]
        public string ReleaseYear { get; set; }

    }
}
