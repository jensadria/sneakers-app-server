using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApi
{
    public class Program
    {
        public static void Main(string[] args) 
        {
/*            var client = new MongoClient("mongodb+srv://jens:sneakerspassword@sneakers.jewio.mongodb.net/sneakers?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");

            var db = client.GetDatabase("sample_mflix");

            var collection = db.GetCollection<BsonDocument>("movies");

            var result = collection.Find("{title:'The Princess Bride'}").FirstOrDefault();

            Console.Write(result);*/

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
