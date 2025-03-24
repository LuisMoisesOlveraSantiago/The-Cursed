using MongoDB.Bson.Serialization.Attributes;

public class TheCursed {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
    public string Personaje { get; set; }
    public string Salud { get; set; }




}