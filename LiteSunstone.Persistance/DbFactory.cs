using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.ObjectModel;

namespace LiteSunstone.Persistance
{
    public  class DbFactory
    {
        private string connectionString;
        private string databaseName;
        private MongoClient client;
        public DbFactory(string connectionString,string databaseName)
        { 
            this.connectionString = connectionString;
            this.databaseName = databaseName;
            this.client = new MongoClient(connectionString);
        }

        public IMongoCollection<BsonDocument> GetCollection(string collection)
        {
           return client.GetDatabase(this.databaseName).GetCollection<BsonDocument>(collection);
        }

    }
}
