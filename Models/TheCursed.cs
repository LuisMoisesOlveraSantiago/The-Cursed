using MongoDB.Bson.Serialization.Attributes;

public class TheCursed {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
    public string Personaje { get; set; } = "";
    public int Salud { get; set; }  
    public int Ataque { get; set; }
    public int Velocidad { get; set; }
    public int? Sangrado { get; set; }
    public string Alimentacion { get; set; } = "";
    public string Altura { get; set; } = "";
    public int? RopturaHueso { get; set; }



}