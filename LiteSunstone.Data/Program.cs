using LiteSunstone.Persistance;
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using LiteSunstone.Domain;
using MongoDB.Bson;
using System.Diagnostics.CodeAnalysis;

namespace LiteSunstone.Data
{
    [ExcludeFromCodeCoverage]
    internal class Program
    {
        static void Main(string[] args)
        {
            var collectionName = "patients";
            var dbName = "litesunstonedb";
            var connectionstr = "mongodb://localhost:27017";
            var client = new MongoClient(connectionstr);
            var db = client.GetDatabase(dbName);
            var collection = db.GetCollection<Patient>(collectionName);
            if (collection == null)
            {
                db.CreateCollection("patients");
                collection = db.GetCollection<Patient>(collectionName);
            }

        }
    }
}