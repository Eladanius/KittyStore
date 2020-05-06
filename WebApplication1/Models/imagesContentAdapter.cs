using MongoDB.Bson.Serialization.Attributes;

namespace KittyStore.Models
{
    public class imagesContentAdapter
    {
        [BsonElement("_id")] public string Id { get; set; }
        [BsonElement("url")] public string Url { get; set; }
        [BsonElement("name")] public string Name { get; set; }
        [BsonElement("age")] public string Age { get; set; }
        [BsonElement("weight")] public string Weight { get; set; }
        [BsonElement("size")] public string Size { get; set; }
        [BsonElement("summary")] public string Summary { get; set; }
    }
}