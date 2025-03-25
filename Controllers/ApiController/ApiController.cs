using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult ListarThe_CursedMongoDB(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Practica2_Alejandro_Luis");
        var collection = db.GetCollection<The_CursedMongo("The_Cursed");

        var lista = collection.Find(FilterDefinition<The_CursedMongo>.Empty).ToList();

        return Ok (Lista);

    }
}