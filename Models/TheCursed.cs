using MongoDB.Bson.Serialization.Attributes;

public class TheCursed {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
    public int Personaje { get; set; }
    public int Daño { get; set; }
    public int Velocidad { get; set; }
    public int Sangrado { get; set; }
    public string Alimentacion { get; set; }
    public string Altura { get; set; }
    public int RopturaHueso { get; set; }



}