using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerce.Catalog.Entities
{
	public class Product
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? ProductId { get; set; }
        public string? ProductName{ get; set; }
        public int ProductStock{ get; set; }
        public string ProductImageURL { get; set; }
        public string ProductDescription { get; set; }

        [BsonIgnore]
        public string ProductCategory { get; set; }
    }
    
}
