using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using Informacion.Api.Models;
using Informacion.Api.Configurations;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using MongoDB.Bson;

namespace Informacion.Api.Services
{
    public class InformacionServices
    {
        private readonly IMongoCollection<Informacion.Api.Models.Informacion> _driverCollection;
        
        public InformacionServices(IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.Value.ConnectionString);
            var mongoDB =
            mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
                _driverCollection =
                    mongoDB.GetCollection<Informacion.Api.Models.Informacion>(databaseSettings.Value.CollectionName);
        }
        public async Task<List<Informacion.Api.Models.Informacion>> GetAsync() =>
            await _driverCollection.Find(_ => true).ToListAsync();
    }
}
