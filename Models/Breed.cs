
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ElGatoBackend.Models

{
    public class Breed
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonElement("Name")]
        public string BreedName { get; set; } = null!;
        [BsonElement("Description")]
        public string BreedDescription { get; set; }=null!;
        [BsonElement("Image")]
        public string BreedImage{ get; set; } = null!;
    }
}
