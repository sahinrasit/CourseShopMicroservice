using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseShop.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
