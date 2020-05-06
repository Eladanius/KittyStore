using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using KittyStore.Models;
using MongoDB.Bson;

namespace KittyStore.Mongo
{
    public static class Service
    {
        static readonly string _connectionString = ConfigurationManager.AppSettings["connectionString"];

        public static List<imagesContentAdapter> GetAllKittiesData(string id = "")
        {
            var filter = string.IsNullOrEmpty(id) ? new BsonDocument() : new BsonDocument("_id", id);
            var mongoClient = new MongoClient(_connectionString);
            return mongoClient.GetDatabase("KittyStore").GetCollection<imagesContentAdapter>("imagesContent").FindSync(filter).ToList();
        }
    }
}